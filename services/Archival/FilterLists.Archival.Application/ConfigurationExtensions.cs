using FilterLists.Archival.Application.Commands;
using FilterLists.Archival.Infrastructure;
using FilterLists.Archival.Infrastructure.Scheduling;
using Hangfire;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Application;

public static class ConfigurationExtensions
{
    public static IHostBuilder UseApplication(this IHostBuilder hostBuilder)
    {
        return hostBuilder.UseInfrastructure();
    }

    public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(typeof(ConfigurationExtensions).Assembly);
        services.AddInfrastructureServices(configuration);
    }

    public static void UseApplication(this IApplicationBuilder app)
    {
        app.UseInfrastructure();
        ScheduleArchival();
    }

    private static void ScheduleArchival()
    {
#if DEBUG
        JobStorage.Current?.GetMonitoringApi()?.PurgeJobs();
        new EnqueueArchiveAllLists.Command().EnqueueBackgroundJob();
#else
            new EnqueueArchiveAllLists.Command().AddOrUpdateRecurringJob(Cron.Daily);
#endif
    }
}
