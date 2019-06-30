using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Infrastructure.Clients;
using FilterLists.Agent.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAgentServices(this IServiceCollection serviceCollection)
        {
            var configurationRoot = BuildConfigurationRoot();
            serviceCollection.AddLogging(b =>
            {
                b.AddConsole();
                b.AddApplicationInsights(configurationRoot["ApplicationInsights:InstrumentationKey"] ?? "");
            });
            serviceCollection.AddMediatR(typeof(Program).Assembly);
            serviceCollection.AddHttpClient<AgentHttpClient>();
            serviceCollection.AddSingleton<IConfiguration>(configurationRoot);
            serviceCollection.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
            serviceCollection.AddTransient<IListInfoRepository, ListInfoRepository>();
        }

        private static IConfigurationRoot BuildConfigurationRoot()
        {
            return new ConfigurationBuilder().AddEnvironmentVariables().Build();
        }
    }
}