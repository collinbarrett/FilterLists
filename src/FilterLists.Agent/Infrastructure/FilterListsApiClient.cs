using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FilterLists.Agent.Entities;
using RestSharp;

namespace FilterLists.Agent.Infrastructure
{
    public interface IFilterListsApiClient
    {
        Task<IEnumerable<ListInfo>> GetListInfo();
    }

    public class FilterListsApiClient : IFilterListsApiClient
    {
        private const string FilterListsApiBaseUrl = "https://filterlists.com/api/v1";
        private const string ExceptionMessage = "Error retrieving response from FilterLists API.";
        private readonly IRestClient _restClient;

        public FilterListsApiClient()
        {
            _restClient = new RestClient(FilterListsApiBaseUrl) {UserAgent = "FilterLists.Agent"};
        }

        public async Task<IEnumerable<ListInfo>> GetListInfo()
        {
            var listsRequest = new RestRequest("lists");
            return await ExecuteAsync<IEnumerable<ListInfo>>(listsRequest);
        }

        private async Task<TResponse> ExecuteAsync<TResponse>(IRestRequest request)
        {
            var response = await _restClient.ExecuteTaskAsync<TResponse>(request);
            if (response.ErrorException == null)
                return response.Data;
            throw new ApplicationException(ExceptionMessage, response.ErrorException);
        }
    }
}