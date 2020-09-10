using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class ConfigurationExtensions
    {
        public static IHostBuilder UseLogging(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseSerilog();
        }

        public static void AddSharedKernelLogging(this IServiceCollection services)
        {
            services.AddApplicationInsightsTelemetry();
        }

        public static void UseLogging(this IApplicationBuilder app)
        {
            app.UseSerilogRequestLogging();
        }
    }
}