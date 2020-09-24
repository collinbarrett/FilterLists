using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class HostRunner
    {
        public static async Task TryRunWithLoggingAsync(this IHost host, Func<Task>? runPreHostAsync = default)
        {
            _ = host ?? throw new ArgumentNullException(nameof(host));

            Log.Logger = ConfigurationBuilder.BaseLoggerConfiguration.CreateLogger();

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
