using System.Text.Json;
using System.Text.Json.Serialization;
using Reusables.Data;

namespace SystemTextJsonGeneratorsApi.JsonConverters
{
    public class SalesOrderHeaderConverter : JsonConverter<SalesOrderHeader>
    {
        public override SalesOrderHeader? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            JsonSerializer.Deserialize<SalesOrderHeader>(ref reader, AdventureWorksContext.Default.SalesOrderHeader);

        public override void Write(Utf8JsonWriter writer, SalesOrderHeader value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value, AdventureWorksContext.Default.SalesOrderHeader);
    }
}
