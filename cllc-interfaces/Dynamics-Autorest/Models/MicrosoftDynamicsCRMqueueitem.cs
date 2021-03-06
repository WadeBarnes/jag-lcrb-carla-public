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
    /// Microsoft.Dynamics.CRM.queueitem
    /// </summary>
    public partial class MicrosoftDynamicsCRMqueueitem
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueueitem
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMqueueitem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMqueueitem
        /// class.
        /// </summary>
        /// <param name="_workeridValue">Shows who is working on the queue
        /// item.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="workeridmodifiedon">Shows the date and time when the
        /// queue item was last assigned to a user.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the queueitem.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_queueidValue">Choose the queue that the item is
        /// assigned to.</param>
        /// <param name="statecode">Shows whether the queue record is active or
        /// inactive. Inactive queue records are read-only and can't be edited
        /// unless they are reactivated.</param>
        /// <param name="enteredon">Shows the date the record was assigned to
        /// the queue.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier of the
        /// business unit that owns the queue item.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="versionnumber">Version number of the queue
        /// item.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the queue item.</param>
        /// <param name="objecttypecode">Select the type of the queue item,
        /// such as activity, case, or appointment.</param>
        /// <param name="queueitemid">Unique identifier of the queue
        /// item.</param>
        /// <param name="statuscode">Select the item's status.</param>
        /// <param name="_objectidValue">Choose the activity, case, or article
        /// assigned to the queue.</param>
        /// <param name="_owninguserValue">Unique identifier of the user who
        /// owns the queue item.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="title">Shows the title or name that describes the
        /// queue record. This value is copied from the record that was
        /// assigned to the queue.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the queue item is associated.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        public MicrosoftDynamicsCRMqueueitem(string _workeridValue = default(string), string _createdbyValue = default(string), string _modifiedbyValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? workeridmodifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), decimal? exchangerate = default(decimal?), int? utcconversiontimezonecode = default(int?), string _queueidValue = default(string), int? statecode = default(int?), System.DateTimeOffset? enteredon = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string versionnumber = default(string), string _owneridValue = default(string), System.DateTimeOffset? adoxioPaymentreceiveddate = default(System.DateTimeOffset?), int? objecttypecode = default(int?), string queueitemid = default(string), int? statuscode = default(int?), string _objectidValue = default(string), string _owninguserValue = default(string), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string title = default(string), string _transactioncurrencyidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMknowledgearticle objectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMappointment objectidAppointment = default(MicrosoftDynamicsCRMappointment), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcampaignactivity objectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMsystemuser workeridSystemuser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMactivitypointer objectidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), MicrosoftDynamicsCRMqueue queueid = default(MicrosoftDynamicsCRMqueue), MicrosoftDynamicsCRMincident objectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMasyncoperation> queueItemAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMteam workeridTeam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMfax objectidFax = default(MicrosoftDynamicsCRMfax), MicrosoftDynamicsCRMrecurringappointmentmaster objectidRecurringappointmentmaster = default(MicrosoftDynamicsCRMrecurringappointmentmaster), IList<MicrosoftDynamicsCRMsyncerror> queueItemSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcampaignresponse objectidCampaignresponse = default(MicrosoftDynamicsCRMcampaignresponse), MicrosoftDynamicsCRMserviceappointment objectidServiceappointment = default(MicrosoftDynamicsCRMserviceappointment), MicrosoftDynamicsCRMletter objectidLetter = default(MicrosoftDynamicsCRMletter), MicrosoftDynamicsCRMsocialactivity objectidSocialactivity = default(MicrosoftDynamicsCRMsocialactivity), MicrosoftDynamicsCRMphonecall objectidPhonecall = default(MicrosoftDynamicsCRMphonecall), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMtask objectidTask = default(MicrosoftDynamicsCRMtask), IList<MicrosoftDynamicsCRMbulkdeletefailure> queueItemBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMemail objectidEmail = default(MicrosoftDynamicsCRMemail), MicrosoftDynamicsCRMbulkoperation objectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMabsScheduledprocessexecution objectidAbsScheduledprocessexecution = default(MicrosoftDynamicsCRMabsScheduledprocessexecution), MicrosoftDynamicsCRMadoxioApplication objectidAdoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMadoxioInvestigation objectidAdoxioInvestigation = default(MicrosoftDynamicsCRMadoxioInvestigation), MicrosoftDynamicsCRMadoxioWorker objectidAdoxioWorker = default(MicrosoftDynamicsCRMadoxioWorker), MicrosoftDynamicsCRMadoxioComplaint objectidAdoxioComplaint = default(MicrosoftDynamicsCRMadoxioComplaint))
        {
            this._workeridValue = _workeridValue;
            this._createdbyValue = _createdbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Importsequencenumber = importsequencenumber;
            Workeridmodifiedon = workeridmodifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Exchangerate = exchangerate;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._queueidValue = _queueidValue;
            Statecode = statecode;
            Enteredon = enteredon;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Overriddencreatedon = overriddencreatedon;
            Versionnumber = versionnumber;
            this._owneridValue = _owneridValue;
            AdoxioPaymentreceiveddate = adoxioPaymentreceiveddate;
            Objecttypecode = objecttypecode;
            Queueitemid = queueitemid;
            Statuscode = statuscode;
            this._objectidValue = _objectidValue;
            this._owninguserValue = _owninguserValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Title = title;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            ObjectidKnowledgearticle = objectidKnowledgearticle;
            Createdby = createdby;
            ObjectidAppointment = objectidAppointment;
            Modifiedby = modifiedby;
            ObjectidCampaignactivity = objectidCampaignactivity;
            WorkeridSystemuser = workeridSystemuser;
            ObjectidActivitypointer = objectidActivitypointer;
            Queueid = queueid;
            ObjectidIncident = objectidIncident;
            QueueItemAsyncOperations = queueItemAsyncOperations;
            WorkeridTeam = workeridTeam;
            ObjectidFax = objectidFax;
            ObjectidRecurringappointmentmaster = objectidRecurringappointmentmaster;
            QueueItemSyncErrors = queueItemSyncErrors;
            Organizationid = organizationid;
            Modifiedonbehalfby = modifiedonbehalfby;
            ObjectidCampaignresponse = objectidCampaignresponse;
            ObjectidServiceappointment = objectidServiceappointment;
            ObjectidLetter = objectidLetter;
            ObjectidSocialactivity = objectidSocialactivity;
            ObjectidPhonecall = objectidPhonecall;
            Transactioncurrencyid = transactioncurrencyid;
            ObjectidTask = objectidTask;
            QueueItemBulkDeleteFailures = queueItemBulkDeleteFailures;
            ObjectidEmail = objectidEmail;
            ObjectidBulkoperation = objectidBulkoperation;
            Createdonbehalfby = createdonbehalfby;
            ObjectidAbsScheduledprocessexecution = objectidAbsScheduledprocessexecution;
            ObjectidAdoxioApplication = objectidAdoxioApplication;
            ObjectidAdoxioInvestigation = objectidAdoxioInvestigation;
            ObjectidAdoxioWorker = objectidAdoxioWorker;
            ObjectidAdoxioComplaint = objectidAdoxioComplaint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows who is working on the queue item.
        /// </summary>
        [JsonProperty(PropertyName = "_workerid_value")]
        public string _workeridValue { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the queue item was last
        /// assigned to a user.
        /// </summary>
        [JsonProperty(PropertyName = "workeridmodifiedon")]
        public System.DateTimeOffset? Workeridmodifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the queueitem.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets choose the queue that the item is assigned to.
        /// </summary>
        [JsonProperty(PropertyName = "_queueid_value")]
        public string _queueidValue { get; set; }

        /// <summary>
        /// Gets or sets shows whether the queue record is active or inactive.
        /// Inactive queue records are read-only and can't be edited unless
        /// they are reactivated.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets shows the date the record was assigned to the queue.
        /// </summary>
        [JsonProperty(PropertyName = "enteredon")]
        public System.DateTimeOffset? Enteredon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// queue item.
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets version number of the queue item.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// queue item.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentreceiveddate")]
        public System.DateTimeOffset? AdoxioPaymentreceiveddate { get; set; }

        /// <summary>
        /// Gets or sets select the type of the queue item, such as activity,
        /// case, or appointment.
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the queue item.
        /// </summary>
        [JsonProperty(PropertyName = "queueitemid")]
        public string Queueitemid { get; set; }

        /// <summary>
        /// Gets or sets select the item's status.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets choose the activity, case, or article assigned to the
        /// queue.
        /// </summary>
        [JsonProperty(PropertyName = "_objectid_value")]
        public string _objectidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the queue item.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the title or name that describes the queue
        /// record. This value is copied from the record that was assigned to
        /// the queue.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// queue item is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_knowledgearticle")]
        public MicrosoftDynamicsCRMknowledgearticle ObjectidKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_appointment")]
        public MicrosoftDynamicsCRMappointment ObjectidAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_campaignactivity")]
        public MicrosoftDynamicsCRMcampaignactivity ObjectidCampaignactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workerid_systemuser")]
        public MicrosoftDynamicsCRMsystemuser WorkeridSystemuser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ObjectidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueid")]
        public MicrosoftDynamicsCRMqueue Queueid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_incident")]
        public MicrosoftDynamicsCRMincident ObjectidIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> QueueItemAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workerid_team")]
        public MicrosoftDynamicsCRMteam WorkeridTeam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_fax")]
        public MicrosoftDynamicsCRMfax ObjectidFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMrecurringappointmentmaster ObjectidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> QueueItemSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_campaignresponse")]
        public MicrosoftDynamicsCRMcampaignresponse ObjectidCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_serviceappointment")]
        public MicrosoftDynamicsCRMserviceappointment ObjectidServiceappointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_letter")]
        public MicrosoftDynamicsCRMletter ObjectidLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_socialactivity")]
        public MicrosoftDynamicsCRMsocialactivity ObjectidSocialactivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_phonecall")]
        public MicrosoftDynamicsCRMphonecall ObjectidPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_task")]
        public MicrosoftDynamicsCRMtask ObjectidTask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QueueItem_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> QueueItemBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_email")]
        public MicrosoftDynamicsCRMemail ObjectidEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_bulkoperation")]
        public MicrosoftDynamicsCRMbulkoperation ObjectidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_abs_scheduledprocessexecution")]
        public MicrosoftDynamicsCRMabsScheduledprocessexecution ObjectidAbsScheduledprocessexecution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_application")]
        public MicrosoftDynamicsCRMadoxioApplication ObjectidAdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_investigation")]
        public MicrosoftDynamicsCRMadoxioInvestigation ObjectidAdoxioInvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_worker")]
        public MicrosoftDynamicsCRMadoxioWorker ObjectidAdoxioWorker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid_adoxio_complaint")]
        public MicrosoftDynamicsCRMadoxioComplaint ObjectidAdoxioComplaint { get; set; }

    }
}
