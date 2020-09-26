using System;
using FilterLists.SharedKernel.Logging.Options;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace FilterLists.SharedKernel.Logging
{
    public static class ConfigurationExtensions
    {
        public static IHostBuilder UseLogging(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseSerilog((_, services, lc) =>
                lc.MinimumLevel.Debug()
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .WriteTo.Conditional(
                        __ => services.GetService<IHostEnvironment>().IsProduction(),
                        sc => sc.ApplicationInsights(
                            services.GetRequiredService<TelemetryConfiguration>(),
                            TelemetryConverter.Traces)));
        }

        public static void AddSharedKernelLogging(this IServiceCollection services, IConfiguration configuration)
        {
            _ = configuration ?? throw new ArgumentNullException(nameof(configuration));

            using var serverTelemetryChannel = new ServerTelemetryChannel
            {
                StorageFolder = configuration.GetSection(ApplicationInsightsOptions.Key)
                    .Get<ApplicationInsightsOptions>()
                    .ServerTelemetryChannelStoragePath
            };
            services.AddSingleton(typeof(ITelemetryChannel), serverTelemetryChannel);
            services.AddApplicationInsightsTelemetry();
        }

        public static void UseLogging(this IApplicationBuilder app)
        {
            app.UseSerilogRequestLogging();
        }
    }
}
