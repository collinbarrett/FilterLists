using System.Threading.Tasks;
using FilterLists.Archival.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Api
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseApplication()
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
    }
}
