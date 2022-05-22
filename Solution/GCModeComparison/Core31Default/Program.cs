using System;
using System.Runtime;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Core31Default
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gcmodeStr = GCSettings.IsServerGC ? "Server" : "Workstation";
            Console.WriteLine($"GC mode: {gcmodeStr}");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
