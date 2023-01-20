using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace FilterLists.Archival.Infrastructure.Scheduling;

internal static class ConfigurationExtensions
{
    private static ConnectionMultiplexer _redis = default!;

    public static void AddScheduling(this IServiceCollection services, IConfiguration configuration)
    {
        _redis = ConnectionMultiplexer.Connect(
            configuration.GetConnectionString("SchedulingConnection") ?? string.Empty);
        services.AddHangfire(
            (_, globalConfiguration) => globalConfiguration.UseRedisStorage(_redis)
                .UseMediatR());
        services.AddHangfireServer(o => o.WorkerCount = Environment.ProcessorCount);
    }
}
