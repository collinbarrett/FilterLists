using System;
using System.Threading;
using Hangfire;
using MediatR;
using Newtonsoft.Json;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    public static class RequestExtensions
    {
        public static void EnqueueBackgroundJob(this IRequest request)
        {
            // Hangfire replaces CancellationToken at runtime with its own. We just need any in the signature.
            // https://docs.hangfire.io/en/latest/background-methods/using-cancellation-tokens.html#cancellationtoken
            BackgroundJob.Enqueue<IMediator>(m => m.Send(request, CancellationToken.None));
        }

        public static void ScheduleBackgroundJob(this IRequest request, TimeSpan delay)
        {
            BackgroundJob.Schedule<IMediator>(m => m.Send(request, CancellationToken.None), delay);
        }

        public static void AddOrUpdateRecurringJob(this IRequest request, Func<string> cronExpression)
        {
            RecurringJob.AddOrUpdate<IMediator>(m => m.Send(request, CancellationToken.None), cronExpression);
        }
    }

    internal static class HangfireExtension
    {
        public static IGlobalConfiguration UseMediatR(this IGlobalConfiguration globalConfiguration)
        {
            /// https://codeopinion.com/background-commands-mediatr-hangfire/
            GlobalConfiguration.Configuration.UseSerializerSettings(
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects });
            return globalConfiguration;
        }
    }
}
