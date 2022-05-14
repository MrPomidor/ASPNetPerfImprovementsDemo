using Microsoft.EntityFrameworkCore;
using Net6Api.Data;

namespace Net6Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
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