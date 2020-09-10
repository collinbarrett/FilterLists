using Microsoft.Extensions.Hosting;
using Serilog;

namespace FilterLists.SharedKernel.Logging
{
    public static class ConfigurationExtensions
    {
        public static IHostBuilder UseLogging(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseSerilog();
        }
    }
}