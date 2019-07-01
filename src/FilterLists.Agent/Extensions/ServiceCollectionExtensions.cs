using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.Interfaces;
using FilterLists.Agent.Infrastructure.Clients;
using FilterLists.Agent.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAgentServices(this IServiceCollection services)
        {
            services.AddConfiguration();
            services.AddLogging(b =>
            {
                b.AddConsole();
                var appInsightsKey = b.Services.BuildServiceProvider().GetService<IOptions<ApplicationInsights>>().Value
                    .InstrumentationKey;
                b.AddApplicationInsights(appInsightsKey);
            });
            services.AddMediatR(typeof(Program).Assembly);
            services.AddHttpClient<AgentHttpClient>();
            services.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();
            services.AddTransient<IListInfoRepository, ListInfoRepository>();
            services.AddTransient<IUrlsRepository, UrlsRepository>();
        }

        private static void AddConfiguration(this IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            services.Configure<ApplicationInsights>(config.GetSection(nameof(ApplicationInsights)));
            services.Configure<ConnectionStrings>(config.GetSection(nameof(ConnectionStrings)));
        }
    }
}