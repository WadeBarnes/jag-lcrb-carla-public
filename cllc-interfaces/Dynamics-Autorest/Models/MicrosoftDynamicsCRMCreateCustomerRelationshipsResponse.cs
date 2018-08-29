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
    /// CreateCustomerRelationshipsResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMCreateCustomerRelationshipsResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCreateCustomerRelationshipsResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCreateCustomerRelationshipsResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMCreateCustomerRelationshipsResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMCreateCustomerRelationshipsResponse(IList<string> relationshipIds = default(IList<string>), string attributeId = default(string))
        {
            RelationshipIds = relationshipIds;
            AttributeId = attributeId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RelationshipIds")]
        public IList<string> RelationshipIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AttributeId")]
        public string AttributeId { get; set; }

    }
}
