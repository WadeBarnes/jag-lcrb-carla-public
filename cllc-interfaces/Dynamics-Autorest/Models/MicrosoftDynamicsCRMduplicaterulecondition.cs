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
    /// Microsoft.Dynamics.CRM.duplicaterulecondition
    /// </summary>
    public partial class MicrosoftDynamicsCRMduplicaterulecondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterulecondition class.
        /// </summary>
        public MicrosoftDynamicsCRMduplicaterulecondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMduplicaterulecondition class.
        /// </summary>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the condition.</param>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the duplicate rule condition.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the condition.</param>
        /// <param name="baseattributename">Field that is being
        /// compared.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the duplicate rule
        /// condition.</param>
        /// <param name="matchingattributename">Field that is being compared
        /// with the base field.</param>
        /// <param name="_regardingobjectidValue">Unique identifier of the
        /// object with which the condition is associated.</param>
        /// <param name="owninguser">Unique identifier of the user who owns the
        /// condition.</param>
        /// <param name="modifiedon">Date and time when the condition was last
        /// modified.</param>
        /// <param name="createdon">Date and time when the condition was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the duplicate rule condition.</param>
        /// <param name="ignoreblankvalues">Determines whether to consider
        /// blank values as non-duplicate values</param>
        /// <param name="operatorparam">Parameter value of N if the operator is
        /// Same First Characters or Same Last Characters.</param>
        /// <param name="owningbusinessunit">Unique identifier of the business
        /// unit that owns the condition.</param>
        /// <param name="duplicateruleconditionid">Unique identifier of the
        /// condition.</param>
        /// <param name="operatorcode">Operator for this rule
        /// condition.</param>
        public MicrosoftDynamicsCRMduplicaterulecondition(string _createdbyValue = default(string), string _owneridValue = default(string), string _modifiedbyValue = default(string), string baseattributename = default(string), string _modifiedonbehalfbyValue = default(string), string matchingattributename = default(string), string _regardingobjectidValue = default(string), string owninguser = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), bool? ignoreblankvalues = default(bool?), int? operatorparam = default(int?), string owningbusinessunit = default(string), string duplicateruleconditionid = default(string), int? operatorcode = default(int?), IList<MicrosoftDynamicsCRMsyncerror> duplicateRuleConditionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMduplicaterule regardingobjectid = default(MicrosoftDynamicsCRMduplicaterule), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._createdbyValue = _createdbyValue;
            this._owneridValue = _owneridValue;
            this._modifiedbyValue = _modifiedbyValue;
            Baseattributename = baseattributename;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Matchingattributename = matchingattributename;
            this._regardingobjectidValue = _regardingobjectidValue;
            Owninguser = owninguser;
            Modifiedon = modifiedon;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Ignoreblankvalues = ignoreblankvalues;
            Operatorparam = operatorparam;
            Owningbusinessunit = owningbusinessunit;
            Duplicateruleconditionid = duplicateruleconditionid;
            Operatorcode = operatorcode;
            DuplicateRuleConditionSyncErrors = duplicateRuleConditionSyncErrors;
            Regardingobjectid = regardingobjectid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user who created the
        /// condition.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// duplicate rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// condition.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets field that is being compared.
        /// </summary>
        [JsonProperty(PropertyName = "baseattributename")]
        public string Baseattributename { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the duplicate rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets field that is being compared with the base field.
        /// </summary>
        [JsonProperty(PropertyName = "matchingattributename")]
        public string Matchingattributename { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the object with which the
        /// condition is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_regardingobjectid_value")]
        public string _regardingobjectidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who owns the condition.
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public string Owninguser { get; set; }

        /// <summary>
        /// Gets or sets date and time when the condition was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the condition was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// duplicate rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets determines whether to consider blank values as
        /// non-duplicate values
        /// </summary>
        [JsonProperty(PropertyName = "ignoreblankvalues")]
        public bool? Ignoreblankvalues { get; set; }

        /// <summary>
        /// Gets or sets parameter value of N if the operator is Same First
        /// Characters or Same Last Characters.
        /// </summary>
        [JsonProperty(PropertyName = "operatorparam")]
        public int? Operatorparam { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the business unit that owns the
        /// condition.
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the condition.
        /// </summary>
        [JsonProperty(PropertyName = "duplicateruleconditionid")]
        public string Duplicateruleconditionid { get; set; }

        /// <summary>
        /// Gets or sets operator for this rule condition.
        /// </summary>
        [JsonProperty(PropertyName = "operatorcode")]
        public int? Operatorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DuplicateRuleCondition_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> DuplicateRuleConditionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMduplicaterule Regardingobjectid { get; set; }

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
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
