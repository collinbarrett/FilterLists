using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
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
                .WriteTo.Console();

        public static LoggerConfiguration WriteToApplicationInsights(
            this LoggerConfiguration loggerConfiguration,
            TelemetryClient? telemetryClient = default)
        {
            var telemetryConverter = TelemetryConverter.Traces;
            return telemetryClient != null
                ? loggerConfiguration.WriteTo.ApplicationInsights(telemetryClient, telemetryConverter)
                : loggerConfiguration.WriteTo.ApplicationInsights(TelemetryConfiguration.Active, telemetryConverter);
        }
    }
}