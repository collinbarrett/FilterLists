using System;
using Hangfire;
using MediatR;
using Newtonsoft.Json;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    /// <remarks>https://codeopinion.com/background-commands-mediatr-hangfire/</remarks>
    public static class MediatorExtensions
    {
        public static void EnqueueBackgroundJob(this IMediator _, IRequest request)
        {
            BackgroundJob.Enqueue<HangfireMediator>(m => m.Send(request));
        }

        public static void AddOrUpdateRecurringJob(
            this IMediator _,
            IRequest request,
            Func<string> cronExpression)
        {
            RecurringJob.AddOrUpdate<HangfireMediator>(m => m.Send(request), cronExpression);
        }
    }

    internal static class HangfireExtension
    {
        public static IGlobalConfiguration UseMediatR(this IGlobalConfiguration config, IMediator mediator)
        {
            config.UseActivator(new MediatorJobActivator(mediator));
            GlobalConfiguration.Configuration.UseSerializerSettings(
                new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Objects});
            return config;
        }
    }

    internal class MediatorJobActivator : JobActivator
    {
        private readonly IMediator _mediator;

        public MediatorJobActivator(IMediator mediator)
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

        public void Send(IRequest request)
        {
            _mediator.Send(request);
        }
    }
}
