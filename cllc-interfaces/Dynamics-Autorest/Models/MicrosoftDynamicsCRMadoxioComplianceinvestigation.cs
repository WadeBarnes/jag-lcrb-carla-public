// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.adoxio_complianceinvestigation
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioComplianceinvestigation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioComplianceinvestigation class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioComplianceinvestigation class.
        /// </summary>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="adoxioComplianceinvestigationid">Unique identifier for
        /// entity instances</param>
        /// <param name="_adoxioLicenseeidValue">Unique identifier for Account
        /// associated with Investigation (Enforcement).</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="_adoxioLicenceidValue">Unique identifier for Licence
        /// associated with Investigation (Enforcement).</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_adoxioRegionidValue">Unique identifier for Region
        /// associated with Investigation (Enforcement).</param>
        /// <param name="_adoxioRegionalmanageridValue">Unique identifier for
        /// User associated with Investigation (Enforcement).</param>
        /// <param name="_adoxioAreaidValue">Unique identifier for Area
        /// associated with Investigation (Enforcement).</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="statuscode">Reason for the status of the
        /// Investigation</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_adoxioEstablishmentidValue">Unique identifier for
        /// Establishment associated with Investigation (Enforcement).</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_adoxioComplaintidValue">Unique identifier for
        /// Complaint associated with Investigation.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="statecode">Status of the Investigation</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        public MicrosoftDynamicsCRMadoxioComplianceinvestigation(System.DateTimeOffset? adoxioCompleteddate = default(System.DateTimeOffset?), string adoxioInvestigationenforcementaction = default(string), string adoxioInvestigationsummary = default(string), int? utcconversiontimezonecode = default(int?), string versionnumber = default(string), string adoxioComplianceinvestigationid = default(string), string _adoxioReactivatebyValue = default(string), System.DateTimeOffset? adoxioApproveddate = default(System.DateTimeOffset?), string adoxioJobnumber = default(string), string _adoxioLicenseeidValue = default(string), string adoxioInvestigationbackground = default(string), string _modifiedbyValue = default(string), string _adoxioLicenceidValue = default(string), string adoxioInvestigationexhibits = default(string), string adoxioAssigneddatetext = default(string), int? timezoneruleversionnumber = default(int?), string _adoxioRegionidValue = default(string), string _adoxioRegionalmanageridValue = default(string), string _adoxioAreaidValue = default(string), string adoxioName = default(string), string _createdbyValue = default(string), int? statuscode = default(int?), string adoxioRmsummary = default(string), int? newRmnotapprovedreason = default(int?), int? adoxioInvestigationoutcome = default(int?), System.DateTimeOffset? adoxioRmreminderemailsentdate = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _owneridValue = default(string), string adoxioReactivationnotes = default(string), string _owningbusinessunitValue = default(string), int? adoxioRecommendedaction = default(int?), int? newIsrmapproved = default(int?), string adoxioInvestigationoffences = default(string), System.DateTimeOffset? adoxioDateinvestigationassigned = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string adoxioInvestigationwitnessstatements = default(string), string adoxioInvestigationdescription = default(string), string _adoxioEstablishmentidValue = default(string), string _owninguserValue = default(string), System.DateTimeOffset? adoxioDateinvestigationconcluded = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? adoxioReactivationdate = default(System.DateTimeOffset?), string _adoxioComplaintidValue = default(string), string _modifiedonbehalfbyValue = default(string), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioRmnotapprovedcomments = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioComplianceinvestigationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioComplianceinvestigationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioComplianceinvestigationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioComplianceinvestigationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioComplianceinvestigationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioComplaint adoxioComplaintId = default(MicrosoftDynamicsCRMadoxioComplaint), MicrosoftDynamicsCRMadoxioEstablishment adoxioEstablishmentId = default(MicrosoftDynamicsCRMadoxioEstablishment), MicrosoftDynamicsCRMaccount adoxioLicenseeId = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> adoxioInvestigationInvestigationactivities = default(IList<MicrosoftDynamicsCRMadoxioInvestigationactivity>), IList<MicrosoftDynamicsCRMincident> adoxioInvestigationInspections = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMadoxioContravention> adoxioInvestigationContraventions = default(IList<MicrosoftDynamicsCRMadoxioContravention>), MicrosoftDynamicsCRMadoxioLicences adoxioLicenceId = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioArea adoxioAreaId = default(MicrosoftDynamicsCRMadoxioArea), MicrosoftDynamicsCRMadoxioRegion adoxioRegionId = default(MicrosoftDynamicsCRMadoxioRegion), IList<MicrosoftDynamicsCRMadoxioRelatedparty> adoxioInvestigationRelatedparties = default(IList<MicrosoftDynamicsCRMadoxioRelatedparty>), IList<MicrosoftDynamicsCRMsharepointdocumentlocation> adoxioComplianceinvestigationSharePointDocumentLocations = default(IList<MicrosoftDynamicsCRMsharepointdocumentlocation>), IList<MicrosoftDynamicsCRMadoxioWitness> adoxioInvestigationwitnesses = default(IList<MicrosoftDynamicsCRMadoxioWitness>), MicrosoftDynamicsCRMsystemuser adoxioRegionalManagerId = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitypointer> adoxioComplianceinvestigationActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> adoxioComplianceinvestigationAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> adoxioComplianceinvestigationEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> adoxioComplianceinvestigationFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> adoxioComplianceinvestigationLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> adoxioComplianceinvestigationPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> adoxioComplianceinvestigationServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> adoxioComplianceinvestigationTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> adoxioComplianceinvestigationRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> adoxioComplianceinvestigationSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> adoxioComplianceinvestigationAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>), IList<MicrosoftDynamicsCRMannotation> adoxioComplianceinvestigationAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory> adoxioComplianceinvestigationAdoxioInvestigationreactivationhistoryInvestigationEnforcement = default(IList<MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory>), MicrosoftDynamicsCRMsystemuser adoxioReactivateBy = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioExhibit> adoxioInvestigationExhibits = default(IList<MicrosoftDynamicsCRMadoxioExhibit>))
        {
            AdoxioCompleteddate = adoxioCompleteddate;
            AdoxioInvestigationenforcementaction = adoxioInvestigationenforcementaction;
            AdoxioInvestigationsummary = adoxioInvestigationsummary;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            AdoxioComplianceinvestigationid = adoxioComplianceinvestigationid;
            this._adoxioReactivatebyValue = _adoxioReactivatebyValue;
            AdoxioApproveddate = adoxioApproveddate;
            AdoxioJobnumber = adoxioJobnumber;
            this._adoxioLicenseeidValue = _adoxioLicenseeidValue;
            AdoxioInvestigationbackground = adoxioInvestigationbackground;
            this._modifiedbyValue = _modifiedbyValue;
            this._adoxioLicenceidValue = _adoxioLicenceidValue;
            AdoxioInvestigationexhibits = adoxioInvestigationexhibits;
            AdoxioAssigneddatetext = adoxioAssigneddatetext;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._adoxioRegionidValue = _adoxioRegionidValue;
            this._adoxioRegionalmanageridValue = _adoxioRegionalmanageridValue;
            this._adoxioAreaidValue = _adoxioAreaidValue;
            AdoxioName = adoxioName;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            AdoxioRmsummary = adoxioRmsummary;
            NewRmnotapprovedreason = newRmnotapprovedreason;
            AdoxioInvestigationoutcome = adoxioInvestigationoutcome;
            AdoxioRmreminderemailsentdate = adoxioRmreminderemailsentdate;
            this._owningteamValue = _owningteamValue;
            this._owneridValue = _owneridValue;
            AdoxioReactivationnotes = adoxioReactivationnotes;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioRecommendedaction = adoxioRecommendedaction;
            NewIsrmapproved = newIsrmapproved;
            AdoxioInvestigationoffences = adoxioInvestigationoffences;
            AdoxioDateinvestigationassigned = adoxioDateinvestigationassigned;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            AdoxioInvestigationwitnessstatements = adoxioInvestigationwitnessstatements;
            AdoxioInvestigationdescription = adoxioInvestigationdescription;
            this._adoxioEstablishmentidValue = _adoxioEstablishmentidValue;
            this._owninguserValue = _owninguserValue;
            AdoxioDateinvestigationconcluded = adoxioDateinvestigationconcluded;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioReactivationdate = adoxioReactivationdate;
            this._adoxioComplaintidValue = _adoxioComplaintidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Statecode = statecode;
            Modifiedon = modifiedon;
            AdoxioRmnotapprovedcomments = adoxioRmnotapprovedcomments;
            Importsequencenumber = importsequencenumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioComplianceinvestigationSyncErrors = adoxioComplianceinvestigationSyncErrors;
            AdoxioComplianceinvestigationDuplicateMatchingRecord = adoxioComplianceinvestigationDuplicateMatchingRecord;
            AdoxioComplianceinvestigationDuplicateBaseRecord = adoxioComplianceinvestigationDuplicateBaseRecord;
            AdoxioComplianceinvestigationAsyncOperations = adoxioComplianceinvestigationAsyncOperations;
            AdoxioComplianceinvestigationBulkDeleteFailures = adoxioComplianceinvestigationBulkDeleteFailures;
            AdoxioComplaintId = adoxioComplaintId;
            AdoxioEstablishmentId = adoxioEstablishmentId;
            AdoxioLicenseeId = adoxioLicenseeId;
            AdoxioInvestigationInvestigationactivities = adoxioInvestigationInvestigationactivities;
            AdoxioInvestigationInspections = adoxioInvestigationInspections;
            AdoxioInvestigationContraventions = adoxioInvestigationContraventions;
            AdoxioLicenceId = adoxioLicenceId;
            AdoxioAreaId = adoxioAreaId;
            AdoxioRegionId = adoxioRegionId;
            AdoxioInvestigationRelatedparties = adoxioInvestigationRelatedparties;
            AdoxioComplianceinvestigationSharePointDocumentLocations = adoxioComplianceinvestigationSharePointDocumentLocations;
            AdoxioInvestigationwitnesses = adoxioInvestigationwitnesses;
            AdoxioRegionalManagerId = adoxioRegionalManagerId;
            AdoxioComplianceinvestigationActivityPointers = adoxioComplianceinvestigationActivityPointers;
            AdoxioComplianceinvestigationAppointments = adoxioComplianceinvestigationAppointments;
            AdoxioComplianceinvestigationEmails = adoxioComplianceinvestigationEmails;
            AdoxioComplianceinvestigationFaxes = adoxioComplianceinvestigationFaxes;
            AdoxioComplianceinvestigationLetters = adoxioComplianceinvestigationLetters;
            AdoxioComplianceinvestigationPhoneCalls = adoxioComplianceinvestigationPhoneCalls;
            AdoxioComplianceinvestigationServiceAppointments = adoxioComplianceinvestigationServiceAppointments;
            AdoxioComplianceinvestigationTasks = adoxioComplianceinvestigationTasks;
            AdoxioComplianceinvestigationRecurringAppointmentMasters = adoxioComplianceinvestigationRecurringAppointmentMasters;
            AdoxioComplianceinvestigationSocialActivities = adoxioComplianceinvestigationSocialActivities;
            AdoxioComplianceinvestigationAbsScheduledprocessexecutions = adoxioComplianceinvestigationAbsScheduledprocessexecutions;
            AdoxioComplianceinvestigationAnnotations = adoxioComplianceinvestigationAnnotations;
            AdoxioComplianceinvestigationAdoxioInvestigationreactivationhistoryInvestigationEnforcement = adoxioComplianceinvestigationAdoxioInvestigationreactivationhistoryInvestigationEnforcement;
            AdoxioReactivateBy = adoxioReactivateBy;
            AdoxioInvestigationExhibits = adoxioInvestigationExhibits;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_completeddate")]
        public System.DateTimeOffset? AdoxioCompleteddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationenforcementaction")]
        public string AdoxioInvestigationenforcementaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationsummary")]
        public string AdoxioInvestigationsummary { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigationid")]
        public string AdoxioComplianceinvestigationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_reactivateby_value")]
        public string _adoxioReactivatebyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_approveddate")]
        public System.DateTimeOffset? AdoxioApproveddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_jobnumber")]
        public string AdoxioJobnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Account associated with
        /// Investigation (Enforcement).
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenseeid_value")]
        public string _adoxioLicenseeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationbackground")]
        public string AdoxioInvestigationbackground { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Licence associated with
        /// Investigation (Enforcement).
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licenceid_value")]
        public string _adoxioLicenceidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationexhibits")]
        public string AdoxioInvestigationexhibits { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_assigneddatetext")]
        public string AdoxioAssigneddatetext { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Region associated with
        /// Investigation (Enforcement).
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionid_value")]
        public string _adoxioRegionidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for User associated with
        /// Investigation (Enforcement).
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionalmanagerid_value")]
        public string _adoxioRegionalmanageridValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Area associated with
        /// Investigation (Enforcement).
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_areaid_value")]
        public string _adoxioAreaidValue { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Investigation
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmsummary")]
        public string AdoxioRmsummary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_rmnotapprovedreason")]
        public int? NewRmnotapprovedreason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationoutcome")]
        public int? AdoxioInvestigationoutcome { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmreminderemailsentdate")]
        public System.DateTimeOffset? AdoxioRmreminderemailsentdate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reactivationnotes")]
        public string AdoxioReactivationnotes { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_recommendedaction")]
        public int? AdoxioRecommendedaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_isrmapproved")]
        public int? NewIsrmapproved { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationoffences")]
        public string AdoxioInvestigationoffences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateinvestigationassigned")]
        public System.DateTimeOffset? AdoxioDateinvestigationassigned { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationwitnessstatements")]
        public string AdoxioInvestigationwitnessstatements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationdescription")]
        public string AdoxioInvestigationdescription { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Establishment associated with
        /// Investigation (Enforcement).
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_establishmentid_value")]
        public string _adoxioEstablishmentidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_dateinvestigationconcluded")]
        public System.DateTimeOffset? AdoxioDateinvestigationconcluded { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_reactivationdate")]
        public System.DateTimeOffset? AdoxioReactivationdate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Complaint associated with
        /// Investigation.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_complaintid_value")]
        public string _adoxioComplaintidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets status of the Investigation
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_rmnotapprovedcomments")]
        public string AdoxioRmnotapprovedcomments { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioComplianceinvestigationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioComplianceinvestigationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioComplianceinvestigationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioComplianceinvestigationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioComplianceinvestigationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ComplaintId")]
        public MicrosoftDynamicsCRMadoxioComplaint AdoxioComplaintId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_EstablishmentId")]
        public MicrosoftDynamicsCRMadoxioEstablishment AdoxioEstablishmentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenseeId")]
        public MicrosoftDynamicsCRMaccount AdoxioLicenseeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_investigationactivities")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationactivity> AdoxioInvestigationInvestigationactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_inspections")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioInvestigationInspections { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_contraventions")]
        public IList<MicrosoftDynamicsCRMadoxioContravention> AdoxioInvestigationContraventions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceId")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AreaId")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioAreaId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionId")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_relatedparties")]
        public IList<MicrosoftDynamicsCRMadoxioRelatedparty> AdoxioInvestigationRelatedparties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_SharePointDocumentLocations")]
        public IList<MicrosoftDynamicsCRMsharepointdocumentlocation> AdoxioComplianceinvestigationSharePointDocumentLocations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigationwitnesses")]
        public IList<MicrosoftDynamicsCRMadoxioWitness> AdoxioInvestigationwitnesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionalManagerId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioRegionalManagerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AdoxioComplianceinvestigationActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AdoxioComplianceinvestigationAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AdoxioComplianceinvestigationEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AdoxioComplianceinvestigationFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AdoxioComplianceinvestigationLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AdoxioComplianceinvestigationPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AdoxioComplianceinvestigationServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioComplianceinvestigationTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AdoxioComplianceinvestigationRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AdoxioComplianceinvestigationSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> AdoxioComplianceinvestigationAbsScheduledprocessexecutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioComplianceinvestigationAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_complianceinvestigation_adoxio_investigationreactivationhistory_InvestigationEnforcement")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigationreactivationhistory> AdoxioComplianceinvestigationAdoxioInvestigationreactivationhistoryInvestigationEnforcement { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ReactivateBy")]
        public MicrosoftDynamicsCRMsystemuser AdoxioReactivateBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_investigation_exhibits")]
        public IList<MicrosoftDynamicsCRMadoxioExhibit> AdoxioInvestigationExhibits { get; set; }

    }
}
