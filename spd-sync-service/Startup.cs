﻿using Gov.Lclb.Cllb.Interfaces;
using Hangfire;
using Hangfire.Console;
using Hangfire.MemoryStorage;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SpdSync;
using Splunk;
using Splunk.Configurations;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: ApiController]
namespace Gov.Lclb.Cllb.SpdSync
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(config =>
            {
                if (!string.IsNullOrEmpty(Configuration["JWT_TOKEN_KEY"]))
                {
                    var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                    config.Filters.Add(new AuthorizeFilter(policy));
                }
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Other ConfigureServices() code...

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "JAG LCRB SPD Transfer Service", Version = "v1" });
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddDefaultTokenProviders();

            if (!string.IsNullOrEmpty(Configuration["JWT_TOKEN_KEY"]))
            {
                // Configure JWT authentication
                services.AddAuthentication(o =>
                {
                    o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(o =>
                {
                    o.SaveToken = true;
                    o.RequireHttpsMetadata = false;
                    o.TokenValidationParameters = new TokenValidationParameters()
                    {
                        RequireExpirationTime = false,
                        ValidIssuer = Configuration["JWT_VALID_ISSUER"],
                        ValidAudience = Configuration["JWT_VALID_AUDIENCE"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT_TOKEN_KEY"]))
                    };
                });
            }

            // determine if we wire up SharePoint.
            if (!string.IsNullOrEmpty(Configuration["SHAREPOINT_ODATA_URI"]))
            {
                SetupSharePoint(services);
            }

            services.AddHangfire(config =>
            {
                // Change this line if you wish to have Hangfire use persistent storage.
                config.UseMemoryStorage();
                // enable console logs for jobs
                config.UseConsole();
            });

            // health checks. 
            services.AddHealthChecks()
                .AddCheck("SPD sync", () => HealthCheckResult.Healthy())
                .AddCheck<SharepointHealthCheck>("Sharepoint");
        }

        private void SetupSharePoint(IServiceCollection services)
        {
            services.AddTransient<SharePointFileManager>(_ => new SharePointFileManager(Configuration));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            bool startHangfire = true;
#if DEBUG
            // do not start Hangfire if we are running tests.        
            foreach (var assem in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                if (assem.FullName.ToLowerInvariant().StartsWith("xunit"))
                {
                    startHangfire = false;
                    break;
                }
            }
#endif

            if (startHangfire)
            {
                // enable Hangfire, using the default authentication model (local connections only)
                app.UseHangfireServer();

                DashboardOptions dashboardOptions = new DashboardOptions
                {
                    AppPath = null
                };

                app.UseHangfireDashboard("/hangfire", dashboardOptions);
            }

            if (!string.IsNullOrEmpty(Configuration["ENABLE_HANGFIRE_JOBS"]))
            {
                SetupHangfireJobs(app, loggerFactory);
            }
            var healthCheckOptions = new HealthCheckOptions
            {
                ResponseWriter = async (c, r) =>
                {
                    c.Response.ContentType = MediaTypeNames.Application.Json;
                    var result = JsonConvert.SerializeObject(
                       new
                       {
                           checks = r.Entries.Select(e =>
                      new
                      {
                          description = e.Key,
                          status = e.Value.Status.ToString(),
                          responseTime = e.Value.Duration.TotalMilliseconds
                      }),
                           totalResponseTime = r.TotalDuration.TotalMilliseconds
                       });
                    await c.Response.WriteAsync(result);
                }
            };
            app.UseHealthChecks("/hc", healthCheckOptions);


            app.UseAuthentication();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "JAG LCRB SPD Transfer Service");
            });

            // enable Splunk logger
            if (!string.IsNullOrEmpty(Configuration["SPLUNK_COLLECTOR_URL"]))
            {
                var splunkLoggerConfiguration = GetSplunkLoggerConfiguration(app);

                //Append Http Json logger
                loggerFactory.AddHECJsonSplunkLogger(splunkLoggerConfiguration);
            }

        }

        SplunkLoggerConfiguration GetSplunkLoggerConfiguration(IApplicationBuilder app)
        {
            SplunkLoggerConfiguration result = null;
            string splunkCollectorUrl = Configuration["SPLUNK_COLLECTOR_URL"];
            if (!string.IsNullOrEmpty(splunkCollectorUrl))
            {
                string splunkToken = Configuration["SPLUNK_TOKEN"];
                if (!string.IsNullOrEmpty(splunkToken))
                {
                    result = new SplunkLoggerConfiguration()
                    {
                        HecConfiguration = new HECConfiguration()
                        {
                            BatchIntervalInMilliseconds = 5000,
                            BatchSizeCount = 10,
                            ChannelIdType = HECConfiguration.ChannelIdOption.None,
                            DefaultTimeoutInMilliseconds = 10000,

                            SplunkCollectorUrl = splunkCollectorUrl,
                            Token = splunkToken,
                            UseAuthTokenAsQueryString = false
                        }
                    };
                }
            }
            return result;
        }

        /// <summary>
        /// Setup the Hangfire jobs.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="loggerFactory"></param>
        private void SetupHangfireJobs(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            ILogger log = loggerFactory.CreateLogger(typeof(Startup));
            log.LogInformation("Starting setup of Hangfire jobs ...");

            try
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    log.LogInformation("Creating Hangfire job for SPD Daily Export ...");
                    RecurringJob.AddOrUpdate(() => new SpdUtils(Configuration, loggerFactory).SendExportJob(null), Cron.Daily);
                    log.LogInformation("Hangfire Send Export job done.");

                }
            }
            catch (Exception e)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine("Failed to setup Hangfire job.");
                log.LogCritical(new EventId(-1, "Hangfire job setup failed"), e, msg.ToString());
            }

            try
            {

                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    log.LogInformation("Creating Hangfire job for Checking SharePoint...");
                    RecurringJob.AddOrUpdate(() => new WorkerUpdater(Configuration, loggerFactory, SpdUtils.SetupSharepoint(Configuration)).ReceiveImportJob(null), Cron.Hourly);
                    log.LogInformation("Hangfire Send Export job done.");
                }
            }
            catch (Exception e)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine("Failed to setup Hangfire job.");
                log.LogCritical(new EventId(-1, "Hangfire job setup failed"), e, msg.ToString());
            }
        }
    }
}
