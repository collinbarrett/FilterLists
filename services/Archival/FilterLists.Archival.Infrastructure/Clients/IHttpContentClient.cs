using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace FilterLists.Archival.Infrastructure.Clients
{
    public interface IHttpContentClient : IDisposable
    {
        Task<Stream> GetContentAsync(Uri url, CancellationToken cancellationToken);
    }

    internal sealed class HttpContentClient : IHttpContentClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICollection<HttpResponseMessage> _httpResponseMessages = new HashSet<HttpResponseMessage>();
        private readonly ILogger _logger;

        public HttpContentClient(HttpClient httpClient, ILogger<HttpContentClient> logger)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36");
            _logger = logger;
        }

        public async Task<Stream> GetContentAsync(Uri url, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            _httpResponseMessages.Add(response);
            try
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStreamAsync(cancellationToken);
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Failed to get content from {Url}", url);
                return Stream.Null;
            }
        }

        public void Dispose()
        {
            foreach (var message in _httpResponseMessages)
            {
                message.Dispose();
            }
        }
    }
}
