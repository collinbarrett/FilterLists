using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Seed.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace FilterLists.Seed;

public class SeedFilterLists
{
    private const string SeedDataDir = "../../../../../../FilterLists/services/Directory/data/";

    // https://stackoverflow.com/a/37749583/2343739
    private static readonly Regex DisallowedCharsInTableKeys = new(@"[\\\\#%+/?\u0000-\u001F\u007F-\u009F]");

    private readonly TableServiceClient _tableServiceClient;

    public SeedFilterLists(TableServiceClient tableServiceClient)
    {
        _tableServiceClient = tableServiceClient;
    }

    [FunctionName("SeedFilterLists")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists/seed")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        var filterLists = await GetSeedEntities<FilterList>();
        var entities = filterLists.Select(l =>
        {
            var listProperties = l.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(p => p.PropertyType == typeof(string) || !typeof(IEnumerable).IsAssignableFrom(p.PropertyType))
                .ToDictionary(
                    prop => prop.Name == nameof(FilterList.Name)
                        ? nameof(TableEntity.PartitionKey)
                        : prop.Name,
                    prop =>
                    {
                        var value = prop.GetValue(l, null);
                        return prop.PropertyType == typeof(Uri)
                            ? value?.ToString()
                            : value;
                    });
            var rowKeyValue = listProperties.GetValueOrDefault(nameof(TableEntity.PartitionKey))!.ToString()!;
            if (DisallowedCharsInTableKeys.IsMatch(rowKeyValue))
                throw new ArgumentException("Invalid key name", rowKeyValue);
            listProperties.Add(nameof(TableEntity.RowKey), rowKeyValue);

            return new TableEntity(listProperties);
        });

        await _tableServiceClient.DeleteTableAsync("filterlists", token);
        await _tableServiceClient.CreateTableAsync("filterlists", token);
        var tableClient = _tableServiceClient.GetTableClient("filterlists");

        foreach (var entity in entities)
            await tableClient.AddEntityAsync(entity, token);

        return new NoContentResult();
    }

    private static async Task<IEnumerable<T>> GetSeedEntities<T>() where T : class
    {
        using var reader = new StreamReader($"{SeedDataDir}{typeof(T).Name}.json");
        var json = await reader.ReadToEndAsync();
        return JsonConvert.DeserializeObject<List<T>>(json);
    }
}