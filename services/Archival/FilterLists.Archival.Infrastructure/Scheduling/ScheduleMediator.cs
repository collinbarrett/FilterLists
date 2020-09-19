using System;
using System.Threading;
using Hangfire;
using MediatR;
using Newtonsoft.Json;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    /// <remarks>https://codeopinion.com/background-commands-mediatr-hangfire/</remarks>
    public static class RequestExtensions
    {
        public static void EnqueueBackgroundJob(this IRequest request)
        {
            // Hangfire replaces CancellationToken at runtime with its own. We just need any in the signature.
            // https://docs.hangfire.io/en/latest/background-methods/using-cancellation-tokens.html#cancellationtoken
            BackgroundJob.Enqueue<HangfireMediator>(m => m.Send(request, CancellationToken.None));
        }

        public static void ScheduleBackgroundJob(this IRequest request, TimeSpan delay)
        {
            BackgroundJob.Schedule<HangfireMediator>(m => m.Send(request, CancellationToken.None), delay);
        }

        public static void AddOrUpdateRecurringJob(this IRequest request, Func<string> cronExpression)
        {
            RecurringJob.AddOrUpdate<HangfireMediator>(m => m.Send(request, CancellationToken.None), cronExpression);
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

        public void Send(IRequest request, CancellationToken cancellationToken)
        {
            _mediator.Send(request, cancellationToken);
        }
    }
}
