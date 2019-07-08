using System;
using System.Threading.Tasks;
using FilterLists.Agent.AppSettings;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using RestSharp;

namespace FilterLists.Agent.Infrastructure.Clients
{
    public class FilterListsApiClient : IFilterListsApiClient
    {
        private readonly IStringLocalizer<FilterListsApiClient> _localizer;
        private readonly IRestClient _restClient;

        public FilterListsApiClient(IStringLocalizer<FilterListsApiClient> stringLocalizer,
            IOptions<FilterListsApiSettings> filterListsApiOptions)
        {
            _localizer = stringLocalizer;
            _restClient = new RestClient(filterListsApiOptions.Value.BaseUrl) {UserAgent = "FilterLists.Agent"};
        }

        public async Task<TResponse> ExecuteAsync<TResponse>(IRestRequest request)
        {
            var response = await _restClient.ExecuteTaskAsync<TResponse>(request);
            if (response.ErrorException == null)
                return response.Data;
            throw new ApplicationException(_localizer["Error retrieving response from the FilterLists API."],
                response.ErrorException);
        }
    }
}