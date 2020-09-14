using System;
using Hangfire;
using MediatR;
using Newtonsoft.Json;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    /// <remarks>https://codeopinion.com/background-commands-mediatr-hangfire/</remarks>
    internal static class HangfireExtension
    {
        public static IGlobalConfiguration UseMediatR(this IGlobalConfiguration config, IMediator mediator)
        {
            config.UseActivator(new MediatRJobActivator(mediator));
            GlobalConfiguration.Configuration.UseSerializerSettings(
                new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Objects});
            return config;
        }
    }

    internal class MediatRJobActivator : JobActivator
    {
        private readonly IMediator _mediator;

        public MediatRJobActivator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override object ActivateJob(Type type)
        {
            return new HangfireMediator(_mediator);
        }
    }

    internal class HangfireMediator
    {
        private readonly IMediator _mediator;

        public HangfireMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SendCommand(IRequest request)
        {
            _mediator.Send(request);
        }
    }

    public static class MediatRExtension
    {
        public static void Enqueue(this IMediator mediator, IRequest request)
        {
            BackgroundJob.Enqueue<HangfireMediator>(m => m.SendCommand(request));
        }
    }
}
