using System.Net;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace QT.OBE.CustomSerializer;


/// <summary>
/// Interface for Json Deserializer
/// </summary>
public class JsonDeserializer : IJsonDeserializer
{
    
    /// <summary>
    /// Deserialize the json string to object
    /// </summary>
    public JsonSerializerOptions SerializerOptions { get; set; } = new(JsonSerializerDefaults.Web)
    {
        DefaultBufferSize = 10,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    
}
