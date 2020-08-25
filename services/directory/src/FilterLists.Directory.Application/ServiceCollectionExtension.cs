using AutoMapper;
using FilterLists.Directory.Infrastructure;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Directory.Application
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(ServiceCollectionExtension).Assembly);
            services.AddAutoMapper(typeof(ServiceCollectionExtension));
            services.AddInfrastructureServices(configuration);
        }
    }
}