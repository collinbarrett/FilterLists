using System;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Features.Lists;
using FilterLists.Agent.Features.Urls;
using FilterLists.Agent.Features.Urls.Models.DataFileUrls;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;

        public static async Task Main()
        {
            BuildServiceProvider();
            var mediator = _serviceProvider.GetService<IOptions<GitHub>>().Value;
            Console.WriteLine(mediator.ProductHeaderValue);
            //await mediator.Send(new CaptureLists.Command());
            //await mediator.Send(new ValidateAllUrls.Command());
        }

        private static void BuildServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.RegisterAgentServices();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}