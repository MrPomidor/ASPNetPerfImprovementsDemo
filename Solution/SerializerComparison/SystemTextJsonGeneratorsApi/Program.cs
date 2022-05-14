using Microsoft.EntityFrameworkCore;
using Reusables.Data;
using SystemTextJsonGeneratorsApi.JsonConverters;

namespace SystemTextJsonGeneratorsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
                .AddControllers()
                .AddJsonOptions(options => {
                    AdventureWorksContext.Init();
                    options.JsonSerializerOptions.Converters.Add(new SalesOrderHeaderConverter());
                    options.JsonSerializerOptions.Converters.Add(new SalesOrderHeaderListConverter());
                });

            builder.Services.AddDbContext<AdventureWorks>((config) =>
            {
                config.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorks"));
            });

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}