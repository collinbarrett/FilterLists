using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    internal static class ServiceCollectionExtension
    {
        private static ConnectionMultiplexer _redis = null!;

        public static void AddSchedulingServices(this IServiceCollection services, IConfiguration configuration)
        {
            _redis = ConnectionMultiplexer.Connect(configuration.GetConnectionString("SchedulingConnection"));
            services.AddHangfire(c => c.UseRedisStorage(_redis));
        }

        public static void UseScheduling(this IApplicationBuilder app)
        {
            app.UseHangfireServer();
        }
    }
}