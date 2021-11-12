using FilterLists.Archival.Infrastructure.Clients;
using FilterLists.Archival.Infrastructure.Persistence;
using FilterLists.Archival.Infrastructure.Scheduling;
using FilterLists.Directory.Api.Contracts;
using FilterLists.SharedKernel.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Infrastructure;

public static class ConfigurationExtensions
{
    public static IHostBuilder ConfigureInfrastructure(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureLogging();
    }

    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSharedKernelLogging(configuration);
        services.AddScheduling(configuration);
        services.AddDirectoryApiClient(configuration);
        services.AddClients();
        services.AddPersistence(configuration);
    }

    public static void UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseLogging();
    }
}
