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
        private readonly ICollection<HttpResponseMessage> _httpResponseMessages = new List<HttpResponseMessage>();
        private readonly ILogger _logger;

        public HttpContentClient(HttpClient httpClient, ILogger<HttpContentClient> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<Stream> GetContentAsync(Uri url, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            _httpResponseMessages.Add(response);
            try
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStreamAsync();
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
