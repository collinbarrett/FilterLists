using System.Threading;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.FilterListsApi
{
    public interface IFilterListsApiClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(IRestRequest restRequest, CancellationToken cancellationToken);
    }

    public class FilterListsApiClient : IFilterListsApiClient
    {
        private readonly IStringLocalizer<FilterListsApiClient> _localizer;
        private readonly ILogger<FilterListsApiClient> _logger;
        private readonly IRestClient _restClient;

        public FilterListsApiClient(IStringLocalizer<FilterListsApiClient> stringLocalizer,
            ILogger<FilterListsApiClient> logger, IOptions<FilterListsApiSettings> filterListsApiOptions)
        {
            _localizer = stringLocalizer;
            _logger = logger;

            var filterListsApiSettings = filterListsApiOptions.Value;
            _restClient = new RestClient(filterListsApiSettings.BaseUrl)
            {
                UserAgent = filterListsApiSettings.ClientUserAgent
            };
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IRestRequest restRequest,
            CancellationToken cancellationToken)
        {
            var response = await _restClient.ExecuteTaskAsync<TResponse>(restRequest, cancellationToken);
            if (response.ErrorException != null)
                _logger.LogError(response.ErrorException,
                    _localizer["Error retrieving response from the FilterLists API."]);
            return response.Data;
        }
    }
}