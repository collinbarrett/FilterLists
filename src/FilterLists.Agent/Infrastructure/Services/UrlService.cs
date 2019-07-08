using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Interfaces.Services;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Infrastructure.Services
{
    [UsedImplicitly]
    public class UrlService : IUrlService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<UrlService> _logger;

        public UrlService(HttpClient httpClient, ILogger<UrlService> logger)
        {
            httpClient.Timeout = TimeSpan.FromSeconds(90);

            var header = new ProductHeaderValue("FilterLists.Agent");
            var userAgent = new ProductInfoHeaderValue(header);
            httpClient.DefaultRequestHeaders.UserAgent.Add(userAgent);

            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<UrlValidationResult> ValidateAsync(Uri u, CancellationToken cancellationToken)
        {
            var result = new UrlValidationResult(u);
            if (!u.IsValidUrl())
            {
                result.SetBroken();
                _logger.LogError($"{u.OriginalString}) is not a valid URL.");
                return result;
            }

            try
            {
                var response =
                    await _httpClient.GetAsync(u, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
                if (u.Scheme == Uri.UriSchemeHttp && await IsHttpsSupported(u, cancellationToken))
                    result.SetSupportsHttps();
                if (response.IsSuccessStatusCode)
                    return result;
                if ((int)response.StatusCode >= 300 && (int)response.StatusCode < 400)
                {
                    result.SetRedirectsTo(response.Headers.Location);
                }
                else
                {
                    result.SetBroken();
                    _logger.LogError(
                        $"Url validation for ({u.AbsoluteUri}) failed with status code: {response.StatusCode}.");
                }

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
        }

        private async Task<bool> IsHttpsSupported(Uri url, CancellationToken cancellationToken)
        {
            var httpsUrl = new UriBuilder(url.OriginalString) {Scheme = Uri.UriSchemeHttps}.Uri;
            try
            {
                var response = await _httpClient.GetAsync(httpsUrl, HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken);
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