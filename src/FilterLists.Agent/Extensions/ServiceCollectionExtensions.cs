using FilterLists.Agent.Infrastructure.Clients;
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
            var configuration = GetConfiguration();
            serviceCollection.AddLogging(b =>
            {
                b.AddConsole();
                b.AddApplicationInsights(configuration["ApplicationInsights:InstrumentationKey"] ?? "");
            });
            serviceCollection.AddMediatR(typeof(Program).Assembly);
            serviceCollection.AddHttpClient<AgentHttpClient>();
            serviceCollection.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
        }

        private static IConfigurationRoot GetConfiguration()
        {
            return new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();
        }
    }
}