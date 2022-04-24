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

        var entities = filterLists.Select(list =>
        {
            var rowKey = list.Name;
            if (DisallowedCharsInTableKeys.IsMatch(list.Name)) // https://stackoverflow.com/a/37749583/2343739
            {
                var oldRowKey = rowKey;
                rowKey = DisallowedCharsInTableKeys.Replace(oldRowKey, "");
                // TODO: customize replaces (e.g., replace '+' w/'&')
                log.LogWarning(
                    "Replaced disallowed characters in Azure Table Storage row key: '{oldRowKey}'. New row key: '{newRowKey}'.",
                    oldRowKey, rowKey);
            }

            var listLicense = licenses.Single(li => li.Id == list.LicenseId);
            var listViewUrls = filterListViewUrls.Where(u => u.FilterListId == list.Id).ToList();
            var listSyntaxes = syntaxes.Where(s =>
                    filterListSyntaxes.Where(fls => fls.FilterListId == list.Id)
                        .Select(fls => fls.SyntaxId)
                        .Contains(s.Id))
                .ToList();
            //var listSoftware = software.Where(s =>
            //    listSyntaxes.Select(ls => ls.Id).ToList()
            //        .Contains(softwareSyntaxes.Where(ss => ss.SoftwareId == s.Id).Select(ss => ss.SyntaxId)));
            var listLanguageIso6391s = languages.Where(la =>
                    filterListLanguages.Where(fll => fll.FilterListId == list.Id)
                        .Select(fll => fll.LanguageId)
                        .Contains(la.Id))
                .ToList();
            var listMaintainers = maintainers.Where(m =>
                    filterListMaintainers.Where(flm => flm.FilterListId == list.Id)
                        .Select(flm => flm.MaintainerId)
                        .Contains(m.Id))
                .ToList();
            var listTags = tags.Where(t =>
                    filterListTags.Where(flt => flt.FilterListId == list.Id)
                        .Select(flt => flt.TagId)
                        .Contains(t.Id))
                .ToList();

            var values = new Dictionary<string, object?>
            {
                { nameof(IFilterListTableEntity.PartitionKey), "filterlist" },
                { nameof(IFilterListTableEntity.RowKey), rowKey },
                { nameof(IFilterListTableEntity.Id), list.Id },
                { nameof(IFilterListTableEntity.Description), list.Description },
                { nameof(IFilterListTableEntity.HomeUrl), list.HomeUrl },
                { nameof(IFilterListTableEntity.OnionUrl), list.OnionUrl },
                { nameof(IFilterListTableEntity.PolicyUrl), list.PolicyUrl },
                { nameof(IFilterListTableEntity.SubmissionUrl), list.SubmissionUrl },
                { nameof(IFilterListTableEntity.IssuesUrl), list.IssuesUrl },
                { nameof(IFilterListTableEntity.ForumUrl), list.ForumUrl },
                { nameof(IFilterListTableEntity.ChatUrl), list.ChatUrl },
                { nameof(IFilterListTableEntity.EmailAddress), list.EmailAddress },
                { nameof(IFilterListTableEntity.DonateUrl), list.DonateUrl },
                { nameof(IFilterListTableEntity.LicenseId), listLicense.Id },
                { nameof(IFilterListTableEntity.LicenseName), listLicense.Name },
                { nameof(IFilterListTableEntity.LicenseUrl), listLicense.Url },
                { nameof(IFilterListTableEntity.LicensePermitsModification), listLicense.PermitsModification },
                { nameof(IFilterListTableEntity.LicensePermitsDistribution), listLicense.PermitsDistribution },
                { nameof(IFilterListTableEntity.LicensePermitsCommercialUse), listLicense.PermitsCommercialUse }
            };

            for (var i = 0; i < listViewUrls.Count; i++)
            {
                var indexerSuffix = ToIndexSuffix(i);
                values.Add($"{nameof(IFilterListTableEntity.ViewUrlSegmentNumber)}{indexerSuffix}", listViewUrls[i].SegmentNumber);
                values.Add($"{nameof(IFilterListTableEntity.ViewUrlPrimariness)}{indexerSuffix}", listViewUrls[i].Primariness);
                values.Add($"{nameof(IFilterListTableEntity.ViewUrl)}{indexerSuffix}", listViewUrls[i].Url);
            }


            for (var i = 0; i < listSyntaxes.Count; i++)
            {
                var indexSuffix = ToIndexSuffix(i);
                values.Add($"{nameof(IFilterListTableEntity.SyntaxId)}{indexSuffix}", listSyntaxes[i].Id);
                values.Add($"{nameof(IFilterListTableEntity.SyntaxName)}{indexSuffix}", listSyntaxes[i].Name);
                values.Add($"{nameof(IFilterListTableEntity.SyntaxDescription)}{indexSuffix}", listSyntaxes[i].Description);
                values.Add($"{nameof(IFilterListTableEntity.SyntaxUrl)}{indexSuffix}", listSyntaxes[i].Url);
            }

            for (var i = 0; i < listLanguageIso6391s.Count; i++)
            {
                var indexSuffix = ToIndexSuffix(i);
                values.Add($"{nameof(IFilterListTableEntity.LanguageIso6391)}{indexSuffix}", listLanguageIso6391s[i].Iso6391);
            }

            for (var i = 0; i < listMaintainers.Count; i++)
            {
                var indexSuffix = ToIndexSuffix(i);
                values.Add($"{nameof(IFilterListTableEntity.MaintainerId)}{indexSuffix}", listMaintainers[i].Id);
                values.Add($"{nameof(IFilterListTableEntity.MaintainerName)}{indexSuffix}", listMaintainers[i].Name);
                values.Add($"{nameof(IFilterListTableEntity.MaintainerUrl)}{indexSuffix}", listMaintainers[i].Url);
                values.Add($"{nameof(IFilterListTableEntity.MaintainerEmailAddress)}{indexSuffix}", listMaintainers[i].EmailAddress);
                values.Add($"{nameof(IFilterListTableEntity.MaintainerTwitterHandle)}{indexSuffix}", listMaintainers[i].TwitterHandle);
            }

            for (var i = 0; i < listTags.Count; i++)
            {
                var indexSuffix = ToIndexSuffix(i);
                values.Add($"{nameof(IFilterListTableEntity.TagId)}{indexSuffix}", listTags[i].Id);
                values.Add($"{nameof(IFilterListTableEntity.TagName)}{indexSuffix}", listTags[i].Name);
                values.Add($"{nameof(IFilterListTableEntity.TagDescription)}{indexSuffix}", listTags[i].Description);
            }

            static string ToIndexSuffix(int i)
            {
                return $"_{(i + 1).ToString().PadLeft(2, '0')}";
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