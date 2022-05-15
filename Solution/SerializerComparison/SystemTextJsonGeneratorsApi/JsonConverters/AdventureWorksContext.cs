using System.Text.Json.Serialization;
using Reusables.Data;

namespace SystemTextJsonGeneratorsApi.JsonConverters
{
    [JsonSerializable(typeof(SalesOrderHeader))]
    [JsonSerializable(typeof(List<SalesOrderHeader>))]
    public partial class AdventureWorksContext : JsonSerializerContext
    {
    }
}
