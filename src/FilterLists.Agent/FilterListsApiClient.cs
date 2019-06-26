using System;
using System.Threading.Tasks;
using RestSharp;

namespace FilterLists.Agent
{
    public interface IFilterListsApiClient
    {
        Task<TResponse> ExecuteAsync<TResponse>(RestRequest request);
    }

    public class FilterListsApiClient : IFilterListsApiClient
    {
        private const string FilterListsApiBaseUrl = "https://filterlists.com/api/v1";
        private const string ExceptionMessage = "Error retrieving response from FilterLists API.";
        private readonly IRestClient restClient;

        public FilterListsApiClient() => restClient = new RestClient(FilterListsApiBaseUrl);

        public async Task<TResponse> ExecuteAsync<TResponse>(RestRequest request)
        {
            var response = await restClient.ExecuteTaskAsync<TResponse>(request);
            if (response.ErrorException == null)
                return response.Data;
            throw new ApplicationException(ExceptionMessage, response.ErrorException);
        }
    }
}