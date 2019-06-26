using System;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public static class Program
    {
        //TODO:  get raw list urls and IDs
        //TODO:  foreach list, download and persist raw list to disk with standardized name and overwriting the previous version
        //TODO:  git add .
        //TODO:  git commit
        //TODO:  foreach list, upsert into MariaDB Rules table https://stackoverflow.com/questions/15271202/mysql-load-data-infile-with-on-duplicate-key-update

        private static IServiceProvider _serviceProvider;

        public static async Task Main()
        {
            RegisterServices();

            var mediator = _serviceProvider.GetService<IMediator>();

            await mediator.Send(new CaptureLists.Command());

            DisposeServices();
        }

        private static void RegisterServices()
        {
            var containerBuilder = new ContainerBuilder();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddMediatR(typeof(Program).Assembly);
            containerBuilder.Populate(serviceCollection);
            var container = containerBuilder.Build();
            _serviceProvider = new AutofacServiceProvider(container);
        }

        private static void DisposeServices()
        {
            switch (_serviceProvider)
            {
                case null:
                    return;
                case IDisposable disposableServiceProvider:
                    disposableServiceProvider.Dispose();
                    break;
            }
        }
    }
}