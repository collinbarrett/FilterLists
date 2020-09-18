using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.Archival.Infrastructure.Clients
{
    internal sealed class FileClient : IFileClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICollection<HttpResponseMessage> _httpResponseMessages = new List<HttpResponseMessage>();

        public FileClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Stream> DownloadFileAsync(Uri url, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            _httpResponseMessages.Add(response);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStreamAsync();
        }

        public void Dispose()
        {
            foreach (var message in _httpResponseMessages)
            {
                message.Dispose();
            }

            _httpClient.Dispose();
        }
    }
}
