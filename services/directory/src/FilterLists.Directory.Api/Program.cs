using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Directory.Api
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await host.MigrateAsync();
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
    }
}