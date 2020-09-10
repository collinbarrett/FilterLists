using System;
using FilterLists.Archival.Infrastructure.Persistence;
using FilterLists.Archival.Infrastructure.Scheduling;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            _ = configuration ?? throw new ArgumentNullException(nameof(configuration));

            services.AddPersistenceServices(configuration);
            services.AddSchedulingServices(configuration);
        }

        public static void UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseScheduling();
        }
    }
}