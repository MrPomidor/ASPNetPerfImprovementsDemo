using System.Text.Json.Serialization;
using Reusables.Data;

namespace SystemTextJsonGeneratorsApi.JsonSerializerContexts
{
    [JsonSerializable(typeof(Product))]
    [JsonSerializable(typeof(SalesOrderDetail))]
    [JsonSerializable(typeof(SalesOrderHeader))]
    public partial class AdventureWorksContext : JsonSerializerContext
    {
    }
}
