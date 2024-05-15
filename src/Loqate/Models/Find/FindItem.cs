using System.Text.Json.Serialization;
using Loqate.JsonSerialization;

namespace Loqate.Models.Find;

public class FindItem
{
    /// <summary>
    /// This can be an address Id or a container Id for further results.
    /// </summary>
    /// <example>
    /// GB|RM|A|52509479.
    /// </example>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// If the Type is 'Address' then the Id can be passed to the Retrieve service. Any other Id should
    /// be passed as the Container to a further Find request to get more results.
    /// </summary>
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// The name of the result.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// A list of number ranges identifying the matched characters in the Text and Description.
    /// </summary>
    [JsonPropertyName("Highlight")]
    [JsonConverter(typeof(FindHighlightsJsonConverter))]
    public List<string> Highlights { get; set; } = [];

    /// <summary>
    /// Descriptive information about the result.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
