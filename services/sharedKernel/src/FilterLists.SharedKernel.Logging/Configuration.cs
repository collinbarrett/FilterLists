using Serilog;
using Serilog.Events;

namespace FilterLists.SharedKernel.Logging
{
    internal static class Configuration
    {
        public static LoggerConfiguration LoggerConfiguration = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.Console();
    }
}