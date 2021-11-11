using FilterLists.Directory.Application;
using FilterLists.Directory.Infrastructure.Persistence;
using FilterLists.SharedKernel.Logging;

namespace FilterLists.Directory.Api;

public static class Program
{
    // TODO: migrate to new hosting model https://docs.microsoft.com/en-us/aspnet/core/migration/50-to-60?view=aspnetcore-6.0&tabs=visual-studio#new-hosting-model
    public static Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        return host.TryRunWithLoggingAsync(() => host.MigrateAsync());
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .UseApplication()
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}
