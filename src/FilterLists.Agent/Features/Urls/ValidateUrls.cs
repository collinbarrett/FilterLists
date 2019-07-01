using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateUrls
    {
        public class Command : IRequest<IEnumerable<Uri>>
        {
            public Command(IEnumerable<Uri> urls)
            {
                Urls = urls;
            }

            public IEnumerable<Uri> Urls { get; }
        }

        public class Handler : IRequestHandler<Command, IEnumerable<Uri>>
        {
            private const int MaxDegreeOfParallelism = 5;
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(AgentHttpClient agentHttpClient, ILogger<Handler> logger)
            {
                _httpClient = agentHttpClient.Client;
                _logger = logger;
            }

            public async Task<IEnumerable<Uri>> Handle(Command request, CancellationToken cancellationToken)
            {
                var validator = BuildValidator(cancellationToken);
                var brokenUrls = new List<Uri>();
                foreach (var url in request.Urls)
                    await validator.SendAsync(url, cancellationToken);
                validator.Complete();
                while (await validator.OutputAvailableAsync(cancellationToken))
                {
                    var (url, result) = await validator.ReceiveAsync(cancellationToken);
                    if (!result)
                        brokenUrls.Add(url);
                }

                await validator.Completion;
                return brokenUrls;
            }

            private TransformBlock<Uri, (Uri, bool)> BuildValidator(CancellationToken cancellationToken)
            {
                return new TransformBlock<Uri, (Uri, bool)>(
                    async u =>
                    {
                        var errorMessage = $"The following URL is broken: {u}.";
                        try
                        {
                            var response = await _httpClient.GetAsync(u, cancellationToken);
                            if (response.IsSuccessStatusCode)
                                return (u, true);
                            _logger.LogError($"{errorMessage} {response.StatusCode}");
                            return (u, false);
                        }
                        catch (HttpRequestException ex)
                        {
                            _logger.LogError(ex, errorMessage);
                            return (u, false);
                        }
                        catch (TaskCanceledException ex)
                        {
                            _logger.LogError(ex, errorMessage);
                            return (u, false);
                        }
                    },
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
            }
        }
    }
}