using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.Urls;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Infrastructure.Web
{
    public class EntityUrlValidator : IEntityUrlValidator
    {
        private readonly HttpClient _httpClient;

        public EntityUrlValidator(HttpClient httpClient, IOptions<FilterListsApiSettings> filterListsApiOptions)
        {
            httpClient.Timeout = TimeSpan.FromSeconds(90);
            var header = new ProductHeaderValue(filterListsApiOptions.Value.ClientUserAgent);
            var userAgent = new ProductInfoHeaderValue(header);
            httpClient.DefaultRequestHeaders.UserAgent.Add(userAgent);
            _httpClient = httpClient;
        }

        public async Task<EntityUrl> ValidateAsync(EntityUrl entityUrl, CancellationToken cancellationToken)
        {
            var url = entityUrl.Url;
            if (!Uri.IsWellFormedUriString(url.OriginalString, UriKind.Absolute))
            {
                entityUrl.SetBroken();
                return entityUrl;
            }

            if (url.Scheme == Uri.UriSchemeHttp)
                if (await IsHttpsSupported(url, cancellationToken))
                    entityUrl.SetSupportsHttps();
            try
            {
                using var response = await GetAsync(url, cancellationToken);
                if ((int)response.StatusCode >= 300 && (int)response.StatusCode < 400)
                    entityUrl.SetRedirectsTo(response.Headers.Location);
                else if (!response.IsSuccessStatusCode)
                    entityUrl.SetBroken();
            }
            catch (Exception ex) when (ex is HttpRequestException ||
                                       ex is TaskCanceledException)
            {
                entityUrl.SetBroken();
            }

            return entityUrl;
        }

        private async Task<bool> IsHttpsSupported(Uri url, CancellationToken cancellationToken)
        {
            var httpsUrl = new UriBuilder(url.OriginalString) {Scheme = Uri.UriSchemeHttps, Port = -1}.Uri;
            try
            {
                using var response = await GetAsync(httpsUrl, cancellationToken);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex) when (ex is HttpRequestException ||
                                       ex is TaskCanceledException)
            {
                return false;
            }
        }

        private async Task<HttpResponseMessage> GetAsync(Uri url, CancellationToken cancellationToken)
        {
            return await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
        }
    }
}