using System.Text.Json;
using System.Text.Json.Serialization;
using Reusables.Data;

namespace SystemTextJsonGeneratorsApi.JsonConverters
{
    public class SalesOrderHeaderListConverter : JsonConverter<List<SalesOrderHeader>>
    {
        public override List<SalesOrderHeader>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            JsonSerializer.Deserialize<List<SalesOrderHeader>>(ref reader, AdventureWorksContext.Default.ListSalesOrderHeader);

        public override void Write(Utf8JsonWriter writer, List<SalesOrderHeader> value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value, AdventureWorksContext.Default.ListSalesOrderHeader);
    }
}
