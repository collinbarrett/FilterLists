using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core;
using FilterLists.Agent.Extensions;
using FilterLists.Agent.Features.Urls.Models.DataFileUrls;
using FilterLists.Agent.Features.Urls.Models.ValidationResults;
using JetBrains.Annotations;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace FilterLists.Agent.Infrastructure
{
    [UsedImplicitly]
    public class UrlRepository : IUrlRepository
    {
        private static readonly Dictionary<string, string> EntityUrlsEndpoints = new Dictionary<string, string>
        {
            {nameof(LicenseUrls), "licenses"},
            {nameof(ListUrls), "lists"},
            {nameof(MaintainerUrls), "maintainers"},
            {nameof(SoftwareUrls), "software"},
            {nameof(SyntaxUrls), "syntaxes"}
        };

        private readonly IRestClient _apiClient;
        private readonly HttpClient _httpClient;
        private readonly IStringLocalizer<UrlRepository> _localizer;
        private readonly ILogger<UrlRepository> _logger;

        public UrlRepository(IRestClient apiClient, HttpClient httpClient,
            IStringLocalizer<UrlRepository> stringLocalizer, ILogger<UrlRepository> logger)
        {
            _apiClient = apiClient;

            httpClient.Timeout = TimeSpan.FromSeconds(90);
            var header = new ProductHeaderValue("FilterLists.Agent");
            var userAgent = new ProductInfoHeaderValue(header);
            httpClient.DefaultRequestHeaders.UserAgent.Add(userAgent);
            _httpClient = httpClient;

            _localizer = stringLocalizer;
            _logger = logger;
        }

        public async Task<IEnumerable<Uri>> GetAllAsync<TModel>(CancellationToken cancellationToken)
        {
            if (!EntityUrlsEndpoints.ContainsKey(typeof(TModel).Name))
                throw new InvalidEnumArgumentException(_localizer["The type of TModel is not valid."]);
            var request = new RestRequest($"{EntityUrlsEndpoints[typeof(TModel).Name]}/seed");
            var response = await _apiClient.ExecuteTaskAsync<IEnumerable<TModel>>(request, cancellationToken);
            if (response.ErrorException != null)
                _logger.LogError(response.ErrorException,
                    _localizer["Error retrieving response from the FilterLists API."]);
            return response.Data.SelectMany(r =>
                r.GetType().GetProperties().Where(p => p.GetValue(r) != null).Select(p => (Uri)p.GetValue(r)));
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