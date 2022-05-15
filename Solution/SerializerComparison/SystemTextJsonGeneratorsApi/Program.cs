using System.Text.Encodings.Web;
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
                    options.JsonSerializerOptions.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
                    options.JsonSerializerOptions.AddContext<AdventureWorksContext>();
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