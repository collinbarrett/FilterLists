using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.FilterLists;

public class SeedFilterLists
{
    private readonly HttpClient _httpClient;
    private readonly TableServiceClient _tableServiceClient;

    public SeedFilterLists(IHttpClientFactory httpClientFactory, TableServiceClient tableServiceClient)
    {
        _httpClient = httpClientFactory.CreateClient();
        _tableServiceClient = tableServiceClient;
    }

    [FunctionName("SeedFilterLists")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "lists/seed")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        using var httpResponse = await _httpClient.GetAsync("https://filterlists.com/api/directory/lists", token);
        httpResponse.EnsureSuccessStatusCode();
        var entities = (await httpResponse.Content.ReadAsAsync<IEnumerable<FilterList>>(token)).Select(l =>
        {
            var listProperties = l.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(
                    prop => prop.Name == nameof(FilterList.Name)
                        ? nameof(TableEntity.PartitionKey)
                        : prop.Name,
                    prop => prop.GetValue(l, null));
            listProperties.Add(nameof(TableEntity.RowKey),
                listProperties.GetValueOrDefault(nameof(TableEntity.PartitionKey)));
            return new TableEntity(listProperties);
        });

        await _tableServiceClient.DeleteTableAsync("filterlists", token);
        await _tableServiceClient.CreateTableAsync("filterlists", token);
        var tableClient = _tableServiceClient.GetTableClient("filterlists");

        foreach (var entity in entities)
            await tableClient.AddEntityAsync(entity, token);
        return new NoContentResult();
    }
}