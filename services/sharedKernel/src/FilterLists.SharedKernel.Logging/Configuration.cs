using Serilog;
using Serilog.Events;

namespace FilterLists.SharedKernel.Logging
{
    internal static class Configuration
    {
        public static LoggerConfiguration LoggerConfiguration = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console();
    }
}