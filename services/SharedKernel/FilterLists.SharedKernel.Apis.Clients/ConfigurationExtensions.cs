using Microsoft.Extensions.DependencyInjection;
using RestSharp;

namespace FilterLists.SharedKernel.Apis.Clients
{
    public static class ConfigurationExtensions
    {
        public static void AddApiClients(this IServiceCollection services)
        {
            services.AddTransient<IRestClient, RestClient>();
        }
    }
}