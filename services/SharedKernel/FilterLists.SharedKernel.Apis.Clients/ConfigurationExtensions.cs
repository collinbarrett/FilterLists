using FilterLists.SharedKernel.Apis.Clients.Directory;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.SharedKernel.Apis.Clients
{
    public static class ConfigurationExtensions
    {
        public static void AddApiClients(this IServiceCollection services)
        {
            services.AddHttpClient<IDirectoryApiClient, DirectoryApiApiClient>();
        }
    }
}
