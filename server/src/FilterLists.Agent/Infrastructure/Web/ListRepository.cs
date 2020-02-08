using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using FilterLists.Agent.Core.Lists;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace FilterLists.Agent.Infrastructure.Web
{
    public class ListRepository : IListRepository
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ListRepository> _logger;

        public ListRepository(HttpClient httpClient, ILogger<ListRepository> logger,
            IOptions<FilterListsApiSettings> filterListsApiOptions)
        {
            httpClient.Timeout = TimeSpan.FromSeconds(90);
            var header = new ProductHeaderValue(filterListsApiOptions.Value.ClientUserAgent);
            var userAgent = new ProductInfoHeaderValue(header);
            httpClient.DefaultRequestHeaders.UserAgent.Add(userAgent);
            _httpClient = httpClient;

            _logger = logger;
        }

        [SuppressMessage("Microsoft.Reliability", "CA2000:DisposeObjectsBeforeLosingScope")]
        public async Task<Stream> GetAsStreamAsync(Uri url, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(url, cancellationToken);
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStreamAsync();
            _logger.LogError($"Error downloading list from {url}. {response.StatusCode}");
            return Stream.Null;
        }
    }
}