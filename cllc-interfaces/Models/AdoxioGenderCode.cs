// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Spice.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AdoxioGenderCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdoxioGenderCode
    {
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female,
        [EnumMember(Value = "Other")]
        Other
    }
    internal static class AdoxioGenderCodeEnumExtension
    {
        internal static string ToSerializedValue(this AdoxioGenderCode? value)
        {
            return value == null ? null : ((AdoxioGenderCode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AdoxioGenderCode value)
        {
            switch( value )
            {
                case AdoxioGenderCode.Male:
                    return "Male";
                case AdoxioGenderCode.Female:
                    return "Female";
                case AdoxioGenderCode.Other:
                    return "Other";
            }
            return null;
        }

        internal static AdoxioGenderCode? ParseAdoxioGenderCode(this string value)
        {
            switch( value )
            {
                case "Male":
                    return AdoxioGenderCode.Male;
                case "Female":
                    return AdoxioGenderCode.Female;
                case "Other":
                    return AdoxioGenderCode.Other;
            }
            return null;
        }
    }
}