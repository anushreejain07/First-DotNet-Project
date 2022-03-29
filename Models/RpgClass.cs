using System.Text.Json.Serialization;

namespace AspNetCoreWebAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] // used because it is showing numbers (0,1,2) instead of name
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric        
    }
}