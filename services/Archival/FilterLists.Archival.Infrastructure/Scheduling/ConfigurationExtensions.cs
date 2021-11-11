using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace FilterLists.Archival.Infrastructure.Scheduling;

internal static class ConfigurationExtensions
{
    private static ConnectionMultiplexer _redis = null!;

    public static void AddSchedulingServices(this IServiceCollection services, IConfiguration configuration)
    {
        _redis = ConnectionMultiplexer.Connect(configuration.GetConnectionString("SchedulingConnection"));
        services.AddHangfire((_, globalConfiguration) => globalConfiguration.UseRedisStorage(_redis).UseMediatR());
    }

    public static void UseScheduling(this IApplicationBuilder app)
    {
        app.UseHangfireServer(new BackgroundJobServerOptions { WorkerCount = Environment.ProcessorCount });
    }
}
