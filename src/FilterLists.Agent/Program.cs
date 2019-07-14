using System;
using System.Threading.Tasks;
using CommandLine;
using FilterLists.Agent.Features.Lists;
using FilterLists.Agent.Features.Urls;
using FilterLists.Agent.Infrastructure.DependencyInjection;
using MediatR;
using Microsoft.ApplicationInsights.Extensibility.PerfCounterCollector.QuickPulse;
using Microsoft.Extensions.DependencyInjection;

namespace FilterLists.Agent
{
    public static class Program
    {
        private static IServiceProvider _serviceProvider;

        public static async Task Main(string[] args)
        {
            _serviceProvider = ServiceProviderBuilder.Build();

            // init never-resolved singleton
            _serviceProvider.GetService<QuickPulseTelemetryModule>();

            var parser = _serviceProvider.GetService<Parser>();
            var mediator = _serviceProvider.GetService<IMediator>();
            await parser.ParseArguments<CommandLineOptions>(args).MapResult(async o =>
                {
                    if (o.ArchiveLists)
                        await mediator.Send(new ArchiveLists.Command());
                    if (o.ValidateUrls)
                        await mediator.Send(new ValidateAllUrls.Command());
                },
                e => Task.FromResult(0)
            );
        }
    }
}