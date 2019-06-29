using System;
using System.IO;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FilterLists.Agent.Infrastructure;
using FilterLists.Agent.ListArchiver;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;

        public static async Task Main()
        {
            RegisterServices();

            var mediator = _serviceProvider.GetService<IMediator>();
            await mediator.Send(new CaptureLists.Command());

            ((IDisposable) _serviceProvider).Dispose();
        }

        private static void RegisterServices()
        {
            var configuration = GetConfiguration();
            var serviceCollection = new ServiceCollection();

            // register Agent services
            serviceCollection.AddLogging(b =>
            {
                b.AddConsole();
                b.AddApplicationInsights(configuration["ApplicationInsights:InstrumentationKey"]);
            });
            serviceCollection.AddMediatR(typeof(Program).Assembly);
            serviceCollection.AddHttpClient<AgentHttpClient>();
            serviceCollection.AddSingleton<IFilterListsApiClient, FilterListsApiClient>();

            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(serviceCollection);
            var container = containerBuilder.Build();
            _serviceProvider = new AutofacServiceProvider(container);
        }

        private static IConfigurationRoot GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, false)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}