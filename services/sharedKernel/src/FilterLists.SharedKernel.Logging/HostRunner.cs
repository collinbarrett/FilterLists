using System;
using System.Threading.Tasks;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class HostRunner
    {
        public static async Task<int> TryRunWithLoggingAsync(Func<Task> runHostAsync)
        {
            Log.Logger = Configuration.LoggerConfiguration.CreateLogger();

            try
            {
                Log.Information("Starting host");
                await runHostAsync();
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