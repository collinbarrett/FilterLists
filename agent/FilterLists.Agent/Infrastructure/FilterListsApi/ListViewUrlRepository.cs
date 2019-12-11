using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.Lists;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public class ListViewUrlRepository : IListViewUrlRepository
    {
        private readonly IFilterListsApiClient _apiClient;

        public ListViewUrlRepository(IFilterListsApiClient filterListsApiClient)
        {
            _apiClient = filterListsApiClient;
        }

        public async Task<IEnumerable<ListViewUrl>> GetAllAsync(CancellationToken cancellationToken)
        {
            var listsRequest = new RestRequest("lists");
            return await _apiClient.ExecuteAsync<IEnumerable<ListViewUrl>>(listsRequest, cancellationToken);
        }
    }
}