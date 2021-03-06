// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.importjob
    /// </summary>
    public partial class MicrosoftDynamicsCRMimportjob
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportjob
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMimportjob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMimportjob
        /// class.
        /// </summary>
        /// <param name="importjobid">Unique identifier of the import
        /// job.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization associated with the importjob.</param>
        /// <param name="data">Unstructured data associated with the import
        /// job.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="solutionname">Unique identifier of the
        /// solution.</param>
        /// <param name="completedon">Date and time when the import job was
        /// completed.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="modifiedon">Date and time when the import job was last
        /// modified.</param>
        /// <param name="name">Name of the import job.</param>
        /// <param name="startedon">Date and time when the import job was
        /// started.</param>
        /// <param name="progress">Import Progress Percentage.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the import job record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the import job record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the importJob.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the importJob.</param>
        /// <param name="createdon">Date and time when the import job record
        /// was created.</param>
        public MicrosoftDynamicsCRMimportjob(string importjobid = default(string), string _organizationidValue = default(string), string data = default(string), int? utcconversiontimezonecode = default(int?), string solutionname = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), System.DateTimeOffset? startedon = default(System.DateTimeOffset?), decimal? progress = default(decimal?), string _modifiedonbehalfbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Importjobid = importjobid;
            this._organizationidValue = _organizationidValue;
            Data = data;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Solutionname = solutionname;
            Completedon = completedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Modifiedon = modifiedon;
            Name = name;
            Startedon = startedon;
            Progress = progress;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Organizationid = organizationid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the import job.
        /// </summary>
        [JsonProperty(PropertyName = "importjobid")]
        public string Importjobid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the importjob.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets unstructured data associated with the import job.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the solution.
        /// </summary>
        [JsonProperty(PropertyName = "solutionname")]
        public string Solutionname { get; set; }

        /// <summary>
        /// Gets or sets date and time when the import job was completed.
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets date and time when the import job was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets name of the import job.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date and time when the import job was started.
        /// </summary>
        [JsonProperty(PropertyName = "startedon")]
        public System.DateTimeOffset? Startedon { get; set; }

        /// <summary>
        /// Gets or sets import Progress Percentage.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public decimal? Progress { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the import job record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// import job record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the
        /// importJob.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the
        /// importJob.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the import job record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
