using FilterLists.SharedKernel.Logging.Options;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.ApplicationInsights.WindowsServer.TelemetryChannel;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging;

public static class ConfigurationExtensions
{
    public static IHostBuilder ConfigureLogging(this IHostBuilder hostBuilder)
    {
        return hostBuilder.UseSerilog();
    }

    public static void AddSharedKernelLogging(this IServiceCollection services, IConfiguration configuration)
    {
        using var serverTelemetryChannel = new ServerTelemetryChannel
        {
            StorageFolder = configuration.GetSection(ApplicationInsightsOptions.Key)
                .Get<ApplicationInsightsOptions>()
                ?.ServerTelemetryChannelStoragePath
        };
        services.AddSingleton(typeof(ITelemetryChannel), serverTelemetryChannel);
        TelemetryDebugWriter.IsTracingDisabled = true;
        services.AddApplicationInsightsTelemetry();
    }

    public static void UseLogging(this IApplicationBuilder app)
    {
        app.UseSerilogRequestLogging();
    }
}
