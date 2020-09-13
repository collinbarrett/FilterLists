using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace FilterLists.SharedKernel.Apis.Clients
{
    internal abstract class BaseApiClient
    {
        protected BaseApiClient(HttpClient httpClient)
        {
            Client = httpClient;
        }

        protected HttpClient Client { get; }

        protected async Task<T> GetAsync<T>(string requestUri, CancellationToken cancellationToken = default)
        {
            var response = await Client.GetAsync(requestUri, cancellationToken);
            response.EnsureSuccessStatusCode();
            await using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseStream, cancellationToken: cancellationToken);
        }
    }
}