using System;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class HostRunner
    {
        public static async Task TryRunWithLoggingAsync(this IHost host, Func<Task>? runPreHostAsync = default)
        {
            _ = host ?? throw new ArgumentNullException(nameof(host));

            var telemetryClient = (TelemetryClient)host.Services.GetService(typeof(TelemetryClient));
            Log.Logger = ConfigurationBuilder.BaseLoggerConfiguration
                .WriteTo.Conditional(
                    _ => host.Services.GetService<IHostEnvironment>().IsProduction(),
                    c => c.ApplicationInsights(telemetryClient, TelemetryConverter.Traces))
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
