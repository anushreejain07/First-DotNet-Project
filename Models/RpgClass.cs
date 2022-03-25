using System.Text.Json.Serialization;

namespace AspNetCoreWebAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric        
    }
}