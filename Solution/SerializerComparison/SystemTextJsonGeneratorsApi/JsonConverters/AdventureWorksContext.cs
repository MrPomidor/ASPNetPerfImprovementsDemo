using System.Text.Json.Serialization;
using Reusables.Data;

namespace SystemTextJsonGeneratorsApi.JsonConverters
{
    [JsonSourceGenerationOptions()]
    [JsonSerializable(typeof(SalesOrderHeader))]
    [JsonSerializable(typeof(List<SalesOrderHeader>))]
    public partial class AdventureWorksContext : JsonSerializerContext
    {
        public static void Init()
        {
            var defaultOptions = new System.Text.Json.JsonSerializerOptions(s_defaultOptions)
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles
            };
            s_defaultContext = new AdventureWorksContext(defaultOptions);
        }
    }
}
