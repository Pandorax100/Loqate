using System.Text.Json;

namespace Pandorax.Loqate.Options;

internal class LoqateJsonSerializerOptions
{
    public static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
    };
}
