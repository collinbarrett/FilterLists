using Serilog;
using Serilog.Events;

namespace FilterLists.SharedKernel.Logging;

internal static class ConfigurationBuilder
{
    public static readonly LoggerConfiguration BaseLoggerConfiguration =
        new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console();
}
