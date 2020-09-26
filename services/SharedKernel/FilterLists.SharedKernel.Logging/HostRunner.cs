using System;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
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

            InitializeLogger(host);

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

        private static void InitializeLogger(IHost host)
        {
            var hostEnvironment = host.Services.GetRequiredService<IHostEnvironment>();
            Log.Logger = ConfigurationBuilder.BaseLoggerConfiguration
                .ReadFrom.Configuration(host.Services.GetRequiredService<IConfiguration>())
                .Enrich.WithProperty("Application", hostEnvironment.ApplicationName)
                .Enrich.WithProperty("Environment", hostEnvironment.EnvironmentName)
                .WriteTo.Conditional(
                    _ => !hostEnvironment.IsProduction(),
                    sc => sc.Console().WriteTo.Debug())
                .WriteTo.Conditional(
                    _ => hostEnvironment.IsProduction(),
                    sc => sc.ApplicationInsights(
                        host.Services.GetRequiredService<TelemetryConfiguration>(),
                        TelemetryConverter.Traces))
                .CreateLogger();
        }
    }
}
