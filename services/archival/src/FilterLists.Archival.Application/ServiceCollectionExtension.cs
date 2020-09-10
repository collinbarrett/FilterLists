using FilterLists.Archival.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Application
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(ServiceCollectionExtension).Assembly);
            services.AddInfrastructureServices(configuration);
        }

        public static void UseApplication(this IApplicationBuilder app)
        {
            app.UseInfrastructure();
        }
    }
}