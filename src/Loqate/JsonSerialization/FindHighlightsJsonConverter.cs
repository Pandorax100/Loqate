using System.Text.Json;
using System.Text.Json.Serialization;

namespace Loqate.JsonSerialization;

internal class FindHighlightsJsonConverter : JsonConverter<List<string>>
{
    public override List<string>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        if (value is not null)
        {
            var split = value.Split(
                new[] { ',', ';' },
                StringSplitOptions.RemoveEmptyEntries);

            return [.. split];
        }

        return [];
    }

    public override void Write(Utf8JsonWriter writer, List<string> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
