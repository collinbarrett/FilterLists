using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.List;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public class ListUrlRepository : IListUrlRepository
    {
        private readonly IRestClient _apiClient;
        private readonly IStringLocalizer<ListUrlRepository> _localizer;
        private readonly ILogger<ListUrlRepository> _logger;

        public ListUrlRepository(IRestClient apiClient, IStringLocalizer<ListUrlRepository> stringLocalizer,
            ILogger<ListUrlRepository> logger)
        {
            _apiClient = apiClient;
            _localizer = stringLocalizer;
            _logger = logger;
        }

        public async Task<IEnumerable<ListUrl>> GetAllAsync(CancellationToken cancellationToken)
        {
            var listsRequest = new RestRequest("lists");
            var response = await _apiClient.ExecuteTaskAsync<IEnumerable<ListUrl>>(listsRequest, cancellationToken);
            if (response.ErrorException != null)
                _logger.LogError(response.ErrorException,
                    _localizer["Error retrieving response from the FilterLists API."]);
            return response.Data;
        }
    }
}