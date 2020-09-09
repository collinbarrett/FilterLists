using FilterLists.Archival.Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Archival.Application
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceCollectionExtension).Assembly);
            services.AddInfrastructureServices();
        }
    }
}