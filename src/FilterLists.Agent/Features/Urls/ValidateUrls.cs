using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateUrls
    {
        public class Command : IRequest<IEnumerable<UrlValidationResult>>
        {
            public Command(IEnumerable<Uri> urls)
            {
                Urls = urls;
            }

            public IEnumerable<Uri> Urls { get; }
        }

        public class Handler : IRequestHandler<Command, IEnumerable<UrlValidationResult>>
        {
            private const int MaxDegreeOfParallelism = 5;
            private readonly HttpClient _httpClient;

            public Handler(AgentHttpClient agentHttpClient)
            {
                _httpClient = agentHttpClient.Client;
            }

            public async Task<IEnumerable<UrlValidationResult>> Handle(Command request,
                CancellationToken cancellationToken)
            {
                var validator = BuildValidator(cancellationToken);
                var brokenUrls = new List<UrlValidationResult>();
                foreach (var url in request.Urls)
                    await validator.SendAsync(url, cancellationToken);
                validator.Complete();
                while (await validator.OutputAvailableAsync(cancellationToken))
                {
                    var result = await validator.ReceiveAsync(cancellationToken);
                    if (!result.IsValid())
                        brokenUrls.Add(result);
                }

                await validator.Completion;
                return brokenUrls;
            }

            private TransformBlock<Uri, UrlValidationResult> BuildValidator(CancellationToken cancellationToken)
            {
                return new TransformBlock<Uri, UrlValidationResult>(
                    async u =>
                    {
                        var result = new UrlValidationResult(u);
                        try
                        {
                            var response = await _httpClient.GetAsync(u, cancellationToken);
                            if (response.IsSuccessStatusCode)
                                return result;
                            if (response.StatusCode == HttpStatusCode.PermanentRedirect ||
                                response.StatusCode == HttpStatusCode.TemporaryRedirect)
                                result.SetRedirectsTo(response.Headers.Location);
                            //TODO: result.SetSupportsHttps();
                            return result;
                        }
                        catch (HttpRequestException)
                        {
                            result.SetBroken();
                            return result;
                        }
                        catch (TaskCanceledException)
                        {
                            result.SetBroken();
                            return result;
                        }
                    },
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
            }
        }
    }
}