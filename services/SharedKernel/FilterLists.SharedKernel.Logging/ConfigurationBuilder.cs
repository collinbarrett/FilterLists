using Serilog;
using Serilog.Events;

namespace FilterLists.SharedKernel.Logging
{
    internal static class ConfigurationBuilder
    {
        public static readonly LoggerConfiguration BaseLoggerConfiguration =
            new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.ApplicationInsights(TelemetryConverter.Traces);
    }
}
