#if DEBUG

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Api.Lists.PostSeed.Models;
using FilterLists.Api.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.Api.Lists.PostSeed;

public class PostSeedLists
{
    private const string SeedDataDir = "../../../../../../FilterLists/services/Directory/data/";

    // https://stackoverflow.com/a/37749583/2343739
    private static readonly Regex DisallowedCharsInTableKeys = new(@"[\\\\#%+/?\u0000-\u001F\u007F-\u009F]");

    private readonly TableServiceClient _tableServiceClient;

    public PostSeedLists(TableServiceClient tableServiceClient)
    {
        _tableServiceClient = tableServiceClient;
    }

    [FunctionName(nameof(PostSeedLists))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists/seed")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        var dependents = await GetSeedEntities<Dependent>();
        var filterLists = await GetSeedEntities<FilterList>();
        var filterListLanguages = await GetSeedEntities<FilterListLanguage>();
        var filterListMaintainers = await GetSeedEntities<FilterListMaintainer>();
        var filterListSyntaxes = await GetSeedEntities<FilterListSyntax>();
        var filterListTags = await GetSeedEntities<FilterListTag>();
        var filterListViewUrls = await GetSeedEntities<FilterListViewUrl>();
        var forks = await GetSeedEntities<Fork>();
        var languages = await GetSeedEntities<Language>();
        var licenses = await GetSeedEntities<License>();
        var maintainers = await GetSeedEntities<Maintainer>();
        var merges = await GetSeedEntities<Merge>();
        var software = await GetSeedEntities<Software>();
        var softwareSyntaxes = await GetSeedEntities<SoftwareSyntax>();
        var syntaxes = await GetSeedEntities<Syntax>();
        var tags = await GetSeedEntities<Tag>();

        var entities = filterLists.Select(l =>
        {
            var rowKey = l.Name;
            if (DisallowedCharsInTableKeys.IsMatch(l.Name))
                rowKey = DisallowedCharsInTableKeys.Replace(rowKey, "");

            var listLicense = licenses.Single(li => li.Id == l.LicenseId);
            var listViewUrls = filterListViewUrls.Where(u => u.FilterListId == l.Id).ToList();
            var listSyntaxes = syntaxes.Where(s =>
                    filterListSyntaxes.Where(fls => fls.FilterListId == l.Id).Select(fls => fls.SyntaxId)
                        .Contains(s.Id))
                .ToList();
            //var listSoftware = software.Where(s =>
            //    listSyntaxes.Select(ls => ls.Id).ToList()
            //        .Contains(softwareSyntaxes.Where(ss => ss.SoftwareId == s.Id).Select(ss => ss.SyntaxId)));
            var values = new Dictionary<string, object?>
            {
                { nameof(FilterListTableEntity.PartitionKey), "filterlist" },
                { nameof(FilterListTableEntity.RowKey), rowKey },
                { nameof(FilterListTableEntity.Id), l.Id },
                { nameof(FilterListTableEntity.Description), l.Description },
                { nameof(FilterListTableEntity.HomeUrl), l.HomeUrl },
                { nameof(FilterListTableEntity.OnionUrl), l.OnionUrl },
                { nameof(FilterListTableEntity.PolicyUrl), l.PolicyUrl },
                { nameof(FilterListTableEntity.SubmissionUrl), l.SubmissionUrl },
                { nameof(FilterListTableEntity.IssuesUrl), l.IssuesUrl },
                { nameof(FilterListTableEntity.ForumUrl), l.ForumUrl },
                { nameof(FilterListTableEntity.ChatUrl), l.ChatUrl },
                { nameof(FilterListTableEntity.EmailAddress), l.EmailAddress },
                { nameof(FilterListTableEntity.DonateUrl), l.DonateUrl },
                { nameof(FilterListTableEntity.LicenseId), listLicense.Id },
                { nameof(FilterListTableEntity.LicenseName), listLicense.Name },
                { nameof(FilterListTableEntity.LicenseUrl), listLicense.Url },
                { nameof(FilterListTableEntity.LicensePermitsModification), listLicense.PermitsModification },
                { nameof(FilterListTableEntity.LicensePermitsDistribution), listLicense.PermitsDistribution },
                { nameof(FilterListTableEntity.LicensePermitsCommercialUse), listLicense.PermitsCommercialUse }
            };

            for (var i = 0; i < listViewUrls.Count; i++)
            {
                values.Add($"{nameof(FilterListTableEntity.ViewUrlSegmentNumber)}{i + 1}",
                    listViewUrls[i].SegmentNumber);
                values.Add($"{nameof(FilterListTableEntity.ViewUrlPrimariness)}{i + 1}", listViewUrls[i].Primariness);
                values.Add($"{nameof(FilterListTableEntity.ViewUrl)}{i + 1}", listViewUrls[i].Url);
            }

            for (var i = 0; i < listSyntaxes.Count; i++)
            {
                values.Add($"{nameof(FilterListTableEntity.SyntaxId)}{i + 1}", listSyntaxes[i].Id);
                values.Add($"{nameof(FilterListTableEntity.SyntaxName)}{i + 1}", listSyntaxes[i].Name);
                values.Add($"{nameof(FilterListTableEntity.SyntaxDescription)}{i + 1}", listSyntaxes[i].Description);
                values.Add($"{nameof(FilterListTableEntity.SyntaxUrl)}{i + 1}", listSyntaxes[i].Url);
            }

            return new TableEntity(values);
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
        return JsonSerializer.Deserialize<List<T>>(json,
            new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })!;
    }
}

#endif