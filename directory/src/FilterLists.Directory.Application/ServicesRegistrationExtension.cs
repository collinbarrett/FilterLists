using FilterLists.Directory.Infrastructure;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Directory.Application
{
    public static class ServicesRegistrationExtension
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(ServicesRegistrationExtension).Assembly);
            services.AddInfrastructureServices(configuration);
        }
    }
}