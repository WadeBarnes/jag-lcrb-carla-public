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
    /// Microsoft.Dynamics.CRM.uom
    /// </summary>
    public partial class MicrosoftDynamicsCRMuom
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuom class.
        /// </summary>
        public MicrosoftDynamicsCRMuom()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMuom class.
        /// </summary>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the uom.</param>
        /// <param name="_modifiedbyexternalpartyValue">Shows the external
        /// party who modified the record.</param>
        /// <param name="name">Type a descriptive title or name for the unit of
        /// measure.</param>
        /// <param name="_uomscheduleidValue">Choose the ID of the unit group
        /// that the unit is associated with.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the uom.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the unit.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="modifiedon">Date and time when the unit was last
        /// modified.</param>
        /// <param name="uomid">Unique identifier of the unit.</param>
        /// <param name="createdon">Date and time when the unit was
        /// created.</param>
        /// <param name="quantity">Unit quantity for the product.</param>
        /// <param name="_baseuomValue">Choose the base or primary unit on
        /// which the unit is based.</param>
        /// <param name="versionnumber">Version number of the unit.</param>
        /// <param name="organizationid">Unique identifier of the organization
        /// associated with the unit of measure.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="_createdbyexternalpartyValue">Shows the external party
        /// who created the record.</param>
        /// <param name="isschedulebaseuom">Tells whether the unit is the base
        /// unit for the associated unit group.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the unit.</param>
        public MicrosoftDynamicsCRMuom(string _modifiedonbehalfbyValue = default(string), string _modifiedbyexternalpartyValue = default(string), string name = default(string), string _uomscheduleidValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string uomid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), decimal? quantity = default(decimal?), string _baseuomValue = default(string), string versionnumber = default(string), string organizationid = default(string), int? importsequencenumber = default(int?), string _createdbyexternalpartyValue = default(string), bool? isschedulebaseuom = default(bool?), string _createdbyValue = default(string), IList<MicrosoftDynamicsCRMproductpricelevel> unitOfMeasurementProductPriceLevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMinvoicedetail> unitOfMeasurementInvoiceDetails = default(IList<MicrosoftDynamicsCRMinvoicedetail>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMuomschedule uomscheduleid = default(MicrosoftDynamicsCRMuomschedule), IList<MicrosoftDynamicsCRMquotedetail> unitOfMeasurementQuoteDetails = default(IList<MicrosoftDynamicsCRMquotedetail>), IList<MicrosoftDynamicsCRMproduct> unitOfMeasurementProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMsalesorderdetail> unitOfMeasurementOrderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMuom baseuom = default(MicrosoftDynamicsCRMuom), IList<MicrosoftDynamicsCRMuom> unitOfMeasurementBaseUnit = default(IList<MicrosoftDynamicsCRMuom>), IList<MicrosoftDynamicsCRMproductassociation> unitOfMeasurementProductassociation = default(IList<MicrosoftDynamicsCRMproductassociation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMcontractdetail> unitOfMeasurementContractLineItems = default(IList<MicrosoftDynamicsCRMcontractdetail>), IList<MicrosoftDynamicsCRMopportunityproduct> unitOfMeasurementOpportunityProducts = default(IList<MicrosoftDynamicsCRMopportunityproduct>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> uoMBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMsyncerror> uoMSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> uoMAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._modifiedbyexternalpartyValue = _modifiedbyexternalpartyValue;
            Name = name;
            this._uomscheduleidValue = _uomscheduleidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            Modifiedon = modifiedon;
            Uomid = uomid;
            Createdon = createdon;
            Quantity = quantity;
            this._baseuomValue = _baseuomValue;
            Versionnumber = versionnumber;
            Organizationid = organizationid;
            Importsequencenumber = importsequencenumber;
            this._createdbyexternalpartyValue = _createdbyexternalpartyValue;
            Isschedulebaseuom = isschedulebaseuom;
            this._createdbyValue = _createdbyValue;
            UnitOfMeasurementProductPriceLevels = unitOfMeasurementProductPriceLevels;
            UnitOfMeasurementInvoiceDetails = unitOfMeasurementInvoiceDetails;
            Createdby = createdby;
            Uomscheduleid = uomscheduleid;
            UnitOfMeasurementQuoteDetails = unitOfMeasurementQuoteDetails;
            UnitOfMeasurementProducts = unitOfMeasurementProducts;
            UnitOfMeasurementOrderDetails = unitOfMeasurementOrderDetails;
            Createdonbehalfby = createdonbehalfby;
            Baseuom = baseuom;
            UnitOfMeasurementBaseUnit = unitOfMeasurementBaseUnit;
            UnitOfMeasurementProductassociation = unitOfMeasurementProductassociation;
            Modifiedonbehalfby = modifiedonbehalfby;
            UnitOfMeasurementContractLineItems = unitOfMeasurementContractLineItems;
            UnitOfMeasurementOpportunityProducts = unitOfMeasurementOpportunityProducts;
            Modifiedby = modifiedby;
            UoMBulkDeleteFailures = uoMBulkDeleteFailures;
            UoMSyncErrors = uoMSyncErrors;
            UoMAsyncOperations = uoMAsyncOperations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the uom.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows the external party who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedbyexternalparty_value")]
        public string _modifiedbyexternalpartyValue { get; set; }

        /// <summary>
        /// Gets or sets type a descriptive title or name for the unit of
        /// measure.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets choose the ID of the unit group that the unit is
        /// associated with.
        /// </summary>
        [JsonProperty(PropertyName = "_uomscheduleid_value")]
        public string _uomscheduleidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// uom.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// unit.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the unit was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the unit.
        /// </summary>
        [JsonProperty(PropertyName = "uomid")]
        public string Uomid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the unit was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unit quantity for the product.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Gets or sets choose the base or primary unit on which the unit is
        /// based.
        /// </summary>
        [JsonProperty(PropertyName = "_baseuom_value")]
        public string _baseuomValue { get; set; }

        /// <summary>
        /// Gets or sets version number of the unit.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization associated with
        /// the unit of measure.
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets shows the external party who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdbyexternalparty_value")]
        public string _createdbyexternalpartyValue { get; set; }

        /// <summary>
        /// Gets or sets tells whether the unit is the base unit for the
        /// associated unit group.
        /// </summary>
        [JsonProperty(PropertyName = "isschedulebaseuom")]
        public bool? Isschedulebaseuom { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the unit.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_product_price_levels")]
        public IList<MicrosoftDynamicsCRMproductpricelevel> UnitOfMeasurementProductPriceLevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_invoice_details")]
        public IList<MicrosoftDynamicsCRMinvoicedetail> UnitOfMeasurementInvoiceDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "uomscheduleid")]
        public MicrosoftDynamicsCRMuomschedule Uomscheduleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_quote_details")]
        public IList<MicrosoftDynamicsCRMquotedetail> UnitOfMeasurementQuoteDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_products")]
        public IList<MicrosoftDynamicsCRMproduct> UnitOfMeasurementProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_order_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> UnitOfMeasurementOrderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "baseuom")]
        public MicrosoftDynamicsCRMuom Baseuom { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_base_unit")]
        public IList<MicrosoftDynamicsCRMuom> UnitOfMeasurementBaseUnit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_productassociation")]
        public IList<MicrosoftDynamicsCRMproductassociation> UnitOfMeasurementProductassociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_contract_line_items")]
        public IList<MicrosoftDynamicsCRMcontractdetail> UnitOfMeasurementContractLineItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit_of_measurement_opportunity_products")]
        public IList<MicrosoftDynamicsCRMopportunityproduct> UnitOfMeasurementOpportunityProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoM_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> UoMBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoM_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> UoMSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UoM_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> UoMAsyncOperations { get; set; }

    }
}
