using System.Threading.Tasks;
using FilterLists.Directory.Application;
using FilterLists.Directory.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using static FilterLists.SharedKernel.Logging.HostRunner;

namespace FilterLists.Directory.Api
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            await TryRunWithLoggingAsync(async () =>
            {
                var host = CreateHostBuilder(args).Build();
                await host.MigrateAsync();
                await host.RunAsync();
            });
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseApplication()
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
    }
}