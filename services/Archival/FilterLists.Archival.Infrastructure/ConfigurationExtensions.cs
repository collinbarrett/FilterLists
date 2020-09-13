using System;
using FilterLists.Archival.Infrastructure.Persistence;
using FilterLists.Archival.Infrastructure.Scheduling;
using FilterLists.SharedKernel.Apis.Clients;
using FilterLists.SharedKernel.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FilterLists.Archival.Infrastructure
{
    public static class ConfigurationExtensions
    {
        public static IHostBuilder UseInfrastructure(this IHostBuilder hostBuilder)
        {
            return hostBuilder.UseLogging();
        }

        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            _ = configuration ?? throw new ArgumentNullException(nameof(configuration));

            services.AddSharedKernelLogging();
            services.AddSchedulingServices(configuration);
            services.AddApiClients();
            services.AddPersistenceServices(configuration);
        }

        public static void UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseLogging();
            app.UseScheduling();
        }
    }
}
