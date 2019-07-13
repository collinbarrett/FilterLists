using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Urls;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace FilterLists.Agent.Infrastructure.Web
{
    [UsedImplicitly]
    public class UrlValidator : IUrlValidator
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<UrlValidator> _logger;

        public UrlValidator(HttpClient httpClient, ILogger<UrlValidator> logger)
        {
            httpClient.Timeout = TimeSpan.FromSeconds(90);
            var header = new ProductHeaderValue("FilterLists.Agent");
            var userAgent = new ProductInfoHeaderValue(header);
            httpClient.DefaultRequestHeaders.UserAgent.Add(userAgent);
            _httpClient = httpClient;

            _logger = logger;
        }

        public async Task<EntityUrl> ValidateAsync(EntityUrl entityUrl, CancellationToken cancellationToken)
        {
            var url = entityUrl.ViewUrl;
            try
            {
                using var response =
                    await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
                if (url.Scheme == Uri.UriSchemeHttp && await IsHttpsSupported(url, cancellationToken))
                    entityUrl.SetSupportsHttps();
                if ((int)response.StatusCode >= 300 && (int)response.StatusCode < 400)
                {
                    entityUrl.SetRedirectsTo(response.Headers.Location);
                }
                else if (!response.IsSuccessStatusCode)
                {
                    entityUrl.SetBroken();
                    _logger.LogError(
                        $"Url validation for ({url.AbsoluteUri}) failed with status code: {response.StatusCode}.");
                }
            }
            catch (HttpRequestException ex)
            {
                entityUrl.SetBroken();
                _logger.LogError($"Url validation for ({url.AbsoluteUri}) failed.", ex);
            }
            catch (TaskCanceledException ex)
            {
                entityUrl.SetBroken();
                _logger.LogError($"Url validation for ({url.AbsoluteUri}) failed.", ex);
            }
            catch (InvalidOperationException ex)
            {
                entityUrl.SetBroken();
                _logger.LogError($"Url validation for ({url.AbsoluteUri}) failed.", ex);
            }

            return entityUrl;
        }

        private async Task<bool> IsHttpsSupported(Uri url, CancellationToken cancellationToken)
        {
            var httpsUrl = new UriBuilder(url.OriginalString) {Scheme = Uri.UriSchemeHttps}.Uri;
            try
            {
                using var response = await _httpClient.GetAsync(httpsUrl, HttpCompletionOption.ResponseHeadersRead,
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