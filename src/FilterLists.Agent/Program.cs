using System;
using System.Net.Http;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using FilterLists.Agent.Infrastructure;
using FilterLists.Agent.ListArchiver;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

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
            var serviceCollection = new ServiceCollection();
            var containerBuilder = new ContainerBuilder();

            // register Agent services
            serviceCollection.AddMediatR(typeof(Program).Assembly);
            containerBuilder.RegisterType<FilterListsApiClient>().AsImplementedInterfaces().SingleInstance();
            containerBuilder.RegisterType<HttpClient>().SingleInstance();

            containerBuilder.Populate(serviceCollection);
            var container = containerBuilder.Build();
            _serviceProvider = new AutofacServiceProvider(container);
        }
    }
}