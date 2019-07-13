using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Polly;
using Polly.Registry;

namespace FilterLists.Agent.Infrastructure.Polly
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPollyPolicyRegistry(this IServiceCollection services)
        {
            var registry = services.AddPolicyRegistry();

            IAsyncPolicy<HttpResponseMessage> waitAndRetryTooManyRequests = Policy
                .HandleResult<HttpResponseMessage>(r => r.StatusCode == HttpStatusCode.TooManyRequests)
                .WaitAndRetryAsync(3,
                    (retryCount, response, context) =>
                        response.Result?.Headers.RetryAfter.Delta ?? TimeSpan.FromMilliseconds(120),
                    async (response, timespan, retryCount, context) =>
                    {
                        await Task.Run(() =>
                        {
                            var logger = services.BuildServiceProvider().GetService<ILogger<IPolicyRegistry<string>>>();
                            logger.LogInformation("Retrying after 429 TooManyRequests",
                                response.Result.RequestMessage.RequestUri,
                                response.Result?.Headers.RetryAfter.Delta.ToString(),
                                retryCount);
                        });
                    });
            registry.Add(nameof(waitAndRetryTooManyRequests), waitAndRetryTooManyRequests);
        }
    }
}