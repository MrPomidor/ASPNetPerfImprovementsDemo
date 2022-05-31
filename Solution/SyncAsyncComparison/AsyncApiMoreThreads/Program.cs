using System;
using System.Threading;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reusables.Data;

namespace AsyncApiMoreThreads
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int WorkerThreads = 70;
            const int CompletionPortThreads = 70;

            if (!ThreadPool.SetMinThreads(WorkerThreads, CompletionPortThreads))
                throw new ApplicationException("Failed to set minimum threads");

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