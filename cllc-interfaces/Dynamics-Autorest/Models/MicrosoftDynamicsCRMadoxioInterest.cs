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

    public partial class MicrosoftDynamicsCRMadoxioInterest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInterest class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInterest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioInterest class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioInterest(string _modifiedbyValue = default(string), object createdon = default(object), object adoxioAmountBase = default(object), int? importsequencenumber = default(int?), string _transactioncurrencyidValue = default(string), string adoxioOccupationorbusiness = default(string), string _owningbusinessunitValue = default(string), object adoxioAmount = default(object), string _createdbyValue = default(string), string _adoxioAccountidValue = default(string), string adoxioInterestid = default(string), string _modifiedonbehalfbyValue = default(string), int? adoxioInteresttype = default(int?), object overriddencreatedon = default(object), int? statuscode = default(int?), string adoxioName = default(string), string _owneridValue = default(string), string _owninguserValue = default(string), string versionnumber = default(string), string adoxioRelationshiptocorporation = default(string), object modifiedon = default(object), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), object exchangerate = default(object), int? statecode = default(int?), string _owningteamValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioInterestSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInterestDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioInterestDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioInterestAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioInterestBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            AdoxioAmountBase = adoxioAmountBase;
            Importsequencenumber = importsequencenumber;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioOccupationorbusiness = adoxioOccupationorbusiness;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioAmount = adoxioAmount;
            this._createdbyValue = _createdbyValue;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            AdoxioInterestid = adoxioInterestid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioInteresttype = adoxioInteresttype;
            Overriddencreatedon = overriddencreatedon;
            Statuscode = statuscode;
            AdoxioName = adoxioName;
            this._owneridValue = _owneridValue;
            this._owninguserValue = _owninguserValue;
            Versionnumber = versionnumber;
            AdoxioRelationshiptocorporation = adoxioRelationshiptocorporation;
            Modifiedon = modifiedon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Exchangerate = exchangerate;
            Statecode = statecode;
            this._owningteamValue = _owningteamValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioInterestSyncErrors = adoxioInterestSyncErrors;
            AdoxioInterestDuplicateMatchingRecord = adoxioInterestDuplicateMatchingRecord;
            AdoxioInterestDuplicateBaseRecord = adoxioInterestDuplicateBaseRecord;
            AdoxioInterestAsyncOperations = adoxioInterestAsyncOperations;
            AdoxioInterestBulkDeleteFailures = adoxioInterestBulkDeleteFailures;
            Transactioncurrencyid = transactioncurrencyid;
            AdoxioAccountId = adoxioAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_amount_base")]
        public object AdoxioAmountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_occupationorbusiness")]
        public string AdoxioOccupationorbusiness { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_amount")]
        public object AdoxioAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public string _adoxioAccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interestid")]
        public string AdoxioInterestid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interesttype")]
        public int? AdoxioInteresttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public object Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_relationshiptocorporation")]
        public string AdoxioRelationshiptocorporation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_interest_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioInterestSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interest_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInterestDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interest_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioInterestDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interest_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioInterestAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_interest_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioInterestBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

    }
}
