// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Spice.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WorkerScreeningResponse
    {
        /// <summary>
        /// Initializes a new instance of the WorkerScreeningResponse class.
        /// </summary>
        public WorkerScreeningResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkerScreeningResponse class.
        /// </summary>
        public WorkerScreeningResponse(string recordIdentifier = default(string), string name = default(string), string givenName = default(string), string surname = default(string), System.DateTimeOffset? birthDate = default(System.DateTimeOffset?), string result = default(string), System.DateTimeOffset? dateProcessed = default(System.DateTimeOffset?))
        {
            RecordIdentifier = recordIdentifier;
            Name = name;
            GivenName = givenName;
            Surname = surname;
            BirthDate = birthDate;
            Result = result;
            DateProcessed = dateProcessed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recordIdentifier")]
        public string RecordIdentifier { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "birthDate")]
        public System.DateTimeOffset? BirthDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateProcessed")]
        public System.DateTimeOffset? DateProcessed { get; set; }

    }
}