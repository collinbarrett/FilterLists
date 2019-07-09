using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.Core.ListInfo;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.Repositories
{
    public class ListInfoRepository : IListInfoRepository
    {
        private readonly IRestClient _apiClient;
        private readonly IStringLocalizer<ListInfoRepository> _localizer;
        private readonly ILogger<ListInfoRepository> _logger;

        public ListInfoRepository(IRestClient apiClient, IStringLocalizer<ListInfoRepository> stringLocalizer,
            ILogger<ListInfoRepository> logger)
        {
            _apiClient = apiClient;
            _localizer = stringLocalizer;
            _logger = logger;
        }

        public async Task<IEnumerable<ListInfo>> GetAllAsync(CancellationToken cancellationToken)
        {
            var listsRequest = new RestRequest("lists");
            var response = await _apiClient.ExecuteTaskAsync<IEnumerable<ListInfo>>(listsRequest, cancellationToken);
            if (response.ErrorException != null)
                _logger.LogError(response.ErrorException,
                    _localizer["Error retrieving response from the FilterLists API."]);
            return response.Data;
        }
    }
}