using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reusables.Data;

namespace SyncApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services
                .AddControllers()
                .AddJsonOptions(options =>
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles
                    );

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