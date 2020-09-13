using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.SharedKernel.Apis.Contracts.Directory;

namespace FilterLists.SharedKernel.Apis.Clients.Directory
{
    internal sealed class DirectoryApiApiClient : BaseApiClient, IDirectoryApiClient
    {
        public DirectoryApiApiClient(HttpClient httpClient, Uri directoryApiBaseUrl) : base(httpClient)
        {
            Client.BaseAddress = directoryApiBaseUrl;
        }

        public async Task<IEnumerable<ListVm>> GetListsAsync(CancellationToken cancellationToken = default)
        {
            return await GetAsync<IEnumerable<ListVm>>("/lists", cancellationToken);
        }

        public async Task<ListDetailsVm> GetListDetailsAsync(int id, CancellationToken cancellationToken = default)
        {
            return await GetAsync<ListDetailsVm>($"/lists/{id}", cancellationToken);
        }
    }
}
