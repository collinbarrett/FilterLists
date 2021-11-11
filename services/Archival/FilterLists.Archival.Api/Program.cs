using FilterLists.Archival.Application;
using FilterLists.SharedKernel.Logging;

namespace FilterLists.Archival.Api
{
    public static class Program
    {
        // TODO: migrate to new hosting model https://docs.microsoft.com/en-us/aspnet/core/migration/50-to-60?view=aspnetcore-6.0&tabs=visual-studio#new-hosting-model
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await host.TryRunWithLoggingAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseApplication()
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
    }
}
