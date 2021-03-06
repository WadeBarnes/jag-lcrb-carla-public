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
    /// Microsoft.Dynamics.CRM.webwizard
    /// </summary>
    public partial class MicrosoftDynamicsCRMwebwizard
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMwebwizard
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMwebwizard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMwebwizard
        /// class.
        /// </summary>
        /// <param name="wizardpageheight">Window height for the
        /// wizard.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the webwizard.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization.</param>
        /// <param name="accessprivileges">Privileges required to use this
        /// wizard, separated with commas (,).</param>
        /// <param name="startpagesequencenumber">Sequence number of the first
        /// page of this wizard.</param>
        /// <param name="webwizardid">Unique identifier of the wizard.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the wizard definition.</param>
        /// <param name="createdon">Date and time when the wizard definition
        /// was created.</param>
        /// <param name="modifiedon">Date and time when the wizard definition
        /// was last modified.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the webwizard.</param>
        /// <param name="wizardpagewidth">Window width for the wizard.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the wizard definition.</param>
        /// <param name="isstaticpagesequence">Information about whether all
        /// pages for this wizard are statically defined.</param>
        /// <param name="name">Name of the wizard</param>
        /// <param name="titleresourcestring">Title of the wizard.</param>
        public MicrosoftDynamicsCRMwebwizard(int? wizardpageheight = default(int?), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), string _organizationidValue = default(string), string accessprivileges = default(string), int? startpagesequencenumber = default(int?), string webwizardid = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? wizardpagewidth = default(int?), string _createdbyValue = default(string), bool? isstaticpagesequence = default(bool?), string name = default(string), string titleresourcestring = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Wizardpageheight = wizardpageheight;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            this._organizationidValue = _organizationidValue;
            Accessprivileges = accessprivileges;
            Startpagesequencenumber = startpagesequencenumber;
            Webwizardid = webwizardid;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            Modifiedon = modifiedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Wizardpagewidth = wizardpagewidth;
            this._createdbyValue = _createdbyValue;
            Isstaticpagesequence = isstaticpagesequence;
            Name = name;
            Titleresourcestring = titleresourcestring;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets window height for the wizard.
        /// </summary>
        [JsonProperty(PropertyName = "wizardpageheight")]
        public int? Wizardpageheight { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the webwizard.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets privileges required to use this wizard, separated with
        /// commas (,).
        /// </summary>
        [JsonProperty(PropertyName = "accessprivileges")]
        public string Accessprivileges { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the first page of this wizard.
        /// </summary>
        [JsonProperty(PropertyName = "startpagesequencenumber")]
        public int? Startpagesequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the wizard.
        /// </summary>
        [JsonProperty(PropertyName = "webwizardid")]
        public string Webwizardid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// wizard definition.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the wizard definition was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the wizard definition was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// webwizard.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets window width for the wizard.
        /// </summary>
        [JsonProperty(PropertyName = "wizardpagewidth")]
        public int? Wizardpagewidth { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the wizard
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets information about whether all pages for this wizard
        /// are statically defined.
        /// </summary>
        [JsonProperty(PropertyName = "isstaticpagesequence")]
        public bool? Isstaticpagesequence { get; set; }

        /// <summary>
        /// Gets or sets name of the wizard
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets title of the wizard.
        /// </summary>
        [JsonProperty(PropertyName = "titleresourcestring")]
        public string Titleresourcestring { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
