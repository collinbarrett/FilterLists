using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;
using FilterLists.Agent.Infrastructure.Clients;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Features.Urls
{
    public static class ValidateUrls
    {
        public class Command : IRequest<List<UrlValidationResult>>
        {
            public Command(IEnumerable<Uri> urls)
            {
                Urls = urls;
            }

            public IEnumerable<Uri> Urls { get; }
        }

        public class Handler : IRequestHandler<Command, List<UrlValidationResult>>
        {
            private const int MaxDegreeOfParallelism = 5;
            private readonly HttpClient _httpClient;
            private readonly ILogger<Handler> _logger;

            public Handler(AgentHttpClient agentHttpClient, ILogger<Handler> logger)
            {
                _httpClient = agentHttpClient.Client;
                _logger = logger;
            }

            public async Task<List<UrlValidationResult>> Handle(Command request, CancellationToken cancellationToken)
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
                        if (!u.IsValidUrl())
                        {
                            result.SetBroken();
                            _logger.LogError($"{u.AbsoluteUri}) is not a valid URL.");
                            return result;
                        }

                        try
                        {
                            var response = await _httpClient.GetAsync(u, cancellationToken);
                            if (response.StatusCode == HttpStatusCode.PermanentRedirect ||
                                response.StatusCode == HttpStatusCode.TemporaryRedirect)
                                result.SetRedirectsTo(response.Headers.Location);
                            if (u.Scheme == Uri.UriSchemeHttp && await IsHttpsSupported(u, cancellationToken))
                                result.SetSupportsHttps();
                            if (response.IsSuccessStatusCode)
                                return result;
                            result.SetBroken();
                            _logger.LogError(
                                $"Url validation for ({u.AbsoluteUri}) failed with status code: {response.StatusCode}.");
                            return result;
                        }
                        catch (HttpRequestException ex)
                        {
                            result.SetBroken();
                            _logger.LogError($"Url validation for ({u.AbsoluteUri}) failed.", ex);
                            return result;
                        }
                        catch (TaskCanceledException ex)
                        {
                            result.SetBroken();
                            _logger.LogError($"Url validation for ({u.AbsoluteUri}) failed.", ex);
                            return result;
                        }
                        catch (InvalidOperationException ex)
                        {
                            result.SetBroken();
                            _logger.LogError($"Url validation for ({u.AbsoluteUri}) failed.", ex);
                            return result;
                        }
                    },
                    new ExecutionDataflowBlockOptions {MaxDegreeOfParallelism = MaxDegreeOfParallelism}
                );
            }

            private async Task<bool> IsHttpsSupported(Uri url, CancellationToken cancellationToken)
            {
                var httpsUrl = new UriBuilder(url.OriginalString) {Scheme = Uri.UriSchemeHttps}.Uri;
                try
                {
                    var response = await _httpClient.GetAsync(httpsUrl, cancellationToken);
                    if (response.IsSuccessStatusCode)
                        return true;
                    _logger.LogError(
                        $"IsHttpsSupported({httpsUrl.AbsoluteUri}) failed with status code: {response.StatusCode}.");
                    return response.IsSuccessStatusCode;
                }
                catch (HttpRequestException ex)
                {
                    _logger.LogError($"IsHttpsSupported({httpsUrl.AbsoluteUri}) failed.", ex);
                    return false;
                }
                catch (TaskCanceledException ex)
                {
                    _logger.LogError($"IsHttpsSupported({httpsUrl.AbsoluteUri}) failed.", ex);
                    return false;
                }
                catch (InvalidOperationException ex)
                {
                    _logger.LogError($"IsHttpsSupported({httpsUrl.AbsoluteUri}) failed.", ex);
                    return false;
                }
            }
        }
    }
}