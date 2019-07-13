using System;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent.Infrastructure.DependencyInjection
{
    public static class ServiceProviderBuilder
    {
        public static IServiceProvider Build()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.ConfigureServices();
            return serviceCollection.BuildServiceProvider();
        }
    }
}