using System;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class HostRunner
    {
        public static async Task<int> TryRunWithLoggingAsync(this IHost host, Func<Task>? runPreHostAsync = default)
        {
            _ = host ?? throw new ArgumentNullException(nameof(host));

            var telemetryClient = (TelemetryClient)host.Services.GetService(typeof(TelemetryClient));
            Log.Logger = ConfigurationBuilder.BaseLoggerConfiguration
                .WriteToApplicationInsights(telemetryClient)
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
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}