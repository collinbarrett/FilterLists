using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class HostRunner
    {
        public static async Task TryRunWithLoggingAsync(this IHost host, Func<Task>? runPreHostAsync = default)
        {
            Log.Logger = ConfigurationBuilder.BaseLoggerConfiguration
                .WriteTo.ApplicationInsights(
                    host.Services.GetRequiredService<TelemetryConfiguration>(),
                    TelemetryConverter.Traces)
                .CreateLogger();

            try
            {
                if (runPreHostAsync != null)
                {
                    Log.Information("Initializing pre-host");
                    await runPreHostAsync();
                }

                Log.Information("Initializing host");
                await host.RunAsync();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
