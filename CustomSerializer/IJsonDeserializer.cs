using System.Text.Json;

namespace QT.OBE.CustomSerializer;

/// <summary>
/// Interface for Json Deserializer
/// </summary>
public interface IJsonDeserializer
{
    /// <summary>
    /// Deserialize the json string to object
    /// </summary>
    JsonSerializerOptions SerializerOptions { get; set; }

    
}
