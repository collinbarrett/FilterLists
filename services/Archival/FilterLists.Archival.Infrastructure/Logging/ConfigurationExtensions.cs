using FilterLists.SharedKernel.Logging;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Infrastructure.Logging
{
    internal static class ConfigurationExtensions
    {
        public static void AddArchivalLogging(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSharedKernelLogging(configuration);
            services.AddTransient(typeof(IRequestPostProcessor<,>), typeof(TelemetryClientFlushPostProcessor<,>));
        }

        public static void UseArchivalLogging(this IApplicationBuilder app)
        {
            app.UseLogging();
        }
    }
}
