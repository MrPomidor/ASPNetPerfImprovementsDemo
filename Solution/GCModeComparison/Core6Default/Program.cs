using System;
using System.Runtime;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reusables.Data;


var gcmodeStr = GCSettings.IsServerGC ? "Server" : "Workstation";
Console.WriteLine($"GC mode: {gcmodeStr}");


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );
builder.Services.AddDbContext<AdventureWorks>((options) =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorks"));
});


var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
