using System;
using System.Threading.Tasks;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Features.Archiver;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;

        public static async Task Main()
        {
            BuildServiceProvider();

            var mediator = _serviceProvider.GetService<IMediator>();
            await mediator.Send(new CaptureLists.Command());
        }

        private static void BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.RegisterAgentServices();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}