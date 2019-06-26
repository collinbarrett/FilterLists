using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
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

        public static void Main()
        {
            RegisterServices();

            //var service = _serviceProvider.GetService<IDemoService>();
            //service.DoSomething();

            DisposeServices();
        }

        private static void RegisterServices()
        {
            var containerBuilder = new ContainerBuilder();
            //builder.RegisterType<DemoService>().As<IDemoService>();
            containerBuilder.Populate(new ServiceCollection());
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