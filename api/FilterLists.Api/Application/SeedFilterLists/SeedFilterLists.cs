using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Application.SeedFilterLists.Models;
using FilterLists.Api.Domain;
using FilterLists.Api.Extensions;
using MediatR;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.Application.SeedFilterLists;

public static class SeedFilterLists
{
    public record Command : IRequest<ResponseVm>
    {
    }

    public class Handler : IRequestHandler<Command, ResponseVm>
    {
        private const string SeedDataDir = "../../../../../../FilterLists/services/Directory/data/";
        private static readonly Regex DisallowedCharsInTableKeys = new(@"[\\\\#%+/?\u0000-\u001F\u007F-\u009F]");
        private readonly ILogger _log;
        private readonly TableServiceClient _tableServiceClient;
        
        public Handler(ILogger<Handler> log, TableServiceClient tableServiceClient)
        {
            _log = log;
            _tableServiceClient = tableServiceClient;
        }

        public async Task<ResponseVm> Handle(Command request, CancellationToken cancellationToken)
        {
            var dependents = await GetSeedEntities<Dependent>();
            var filterLists = (await GetSeedEntities<FilterList>()).Select(l => new FilterList
            {
                Id = l.Id,
                Name = SanitizeKey(l.Name, _log),
                Description = l.Description,
                LicenseId = l.LicenseId,
                HomeUrl = l.HomeUrl,
                OnionUrl = l.OnionUrl,
                PolicyUrl = l.PolicyUrl,
                SubmissionUrl = l.SubmissionUrl,
                IssuesUrl = l.IssuesUrl,
                ForumUrl = l.ForumUrl,
                ChatUrl = l.ChatUrl,
                EmailAddress = l.EmailAddress,
                DonateUrl = l.DonateUrl
            }).ToList();
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
                var listLicense = licenses.Single(li => li.Id == list.LicenseId);
                var listViewUrls = filterListViewUrls.Where(u => u.FilterListId == list.Id).ToList();
                var listSyntaxes = syntaxes.Where(s =>
                        filterListSyntaxes.Where(fls => fls.FilterListId == list.Id)
                            .Select(fls => fls.SyntaxId)
                            .Contains(s.Id))
                    .ToList();
                var listSoftware = software.Where(s =>
                        softwareSyntaxes.Where(ss => listSyntaxes.Select(ls => ls.Id).Contains(ss.SyntaxId))
                            .Select(ss => ss.SoftwareId)
                            .Contains(s.Id))
                    .ToList();
                var listLanguageIso6391s = languages.Where(la =>
                        filterListLanguages.Where(fll => fll.FilterListId == list.Id)
                            .Select(fll => fll.LanguageId)
                            .Contains(la.Id))
                    .Select(la => la.Iso6391)
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
                var listUpstreamListNames = filterLists.Where(fl =>
                        forks.Where(fo => fo.ForkFilterListId == list.Id)
                            .Select(fo => fo.UpstreamFilterListId)
                            .Contains(fl.Id))
                    .Select(fo => fo.Name)
                    .ToList();
                var listForkListNames = filterLists.Where(fl =>
                        forks.Where(fo => fo.UpstreamFilterListId == list.Id)
                            .Select(fo => fo.ForkFilterListId)
                            .Contains(fl.Id))
                    .Select(fo => fo.Name)
                    .ToList();
                var listIncludedInListNames = filterLists.Where(fl =>
                        merges.Where(m => m.IncludesFilterListId == list.Id)
                            .Select(m => m.IncludedInFilterListId)
                            .Contains(fl.Id))
                    .Select(m => m.Name)
                    .ToList();
                var listIncludesListNames = filterLists.Where(fl =>
                        merges.Where(m => m.IncludedInFilterListId == list.Id)
                            .Select(m => m.IncludesFilterListId)
                            .Contains(fl.Id))
                    .Select(m => m.Name)
                    .ToList();
                var listDependencyListNames = filterLists.Where(fl =>
                        dependents.Where(d => d.DependentFilterListId == list.Id)
                            .Select(d => d.DependencyFilterListId)
                            .Contains(fl.Id))
                    .Select(d => d.Name)
                    .ToList();
                var listDependentListNames = filterLists.Where(fl =>
                        dependents.Where(d => d.DependencyFilterListId == list.Id)
                            .Select(d => d.DependentFilterListId)
                            .Contains(fl.Id))
                    .Select(d => d.Name)
                    .ToList();

                var values = new Dictionary<string, object?>
                {
                    { nameof(IFilterListTableEntity.PartitionKey), TableStorageConstants.FilterListsPartitionKey },
                    { nameof(IFilterListTableEntity.RowKey), list.Name },
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
                    var indexerSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.ViewUrlSegmentNumber)}{indexerSuffix}", listViewUrls[i].SegmentNumber);
                    values.Add($"{nameof(IFilterListTableEntity.ViewUrlPrimariness)}{indexerSuffix}", listViewUrls[i].Primariness);
                    values.Add($"{nameof(IFilterListTableEntity.ViewUrl)}{indexerSuffix}", listViewUrls[i].Url);
                }

                for (var i = 0; i < listSyntaxes.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxId)}{indexSuffix}", listSyntaxes[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxName)}{indexSuffix}", listSyntaxes[i].Name);
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxDescription)}{indexSuffix}", listSyntaxes[i].Description);
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxUrl)}{indexSuffix}", listSyntaxes[i].Url);
                }

                for (var i = 0; i < listSoftware.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareId)}{indexSuffix}", listSoftware[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareName)}{indexSuffix}", listSoftware[i].Name);
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareDescription)}{indexSuffix}", listSoftware[i].Description);
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareHomeUrl)}{indexSuffix}", listSoftware[i].HomeUrl);
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareDownloadUrl)}{indexSuffix}", listSoftware[i].DownloadUrl);
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareSupportsAbpUrlScheme)}{indexSuffix}", listSoftware[i].SupportsAbpUrlScheme);
                }

                for (var i = 0; i < listLanguageIso6391s.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.LanguageIso6391)}{indexSuffix}", listLanguageIso6391s[i]);
                }

                for (var i = 0; i < listMaintainers.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerId)}{indexSuffix}", listMaintainers[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerName)}{indexSuffix}", listMaintainers[i].Name);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerUrl)}{indexSuffix}", listMaintainers[i].Url);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerEmailAddress)}{indexSuffix}", listMaintainers[i].EmailAddress);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerTwitterHandle)}{indexSuffix}", listMaintainers[i].TwitterHandle);
                }

                for (var i = 0; i < listTags.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.TagId)}{indexSuffix}", listTags[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.TagName)}{indexSuffix}", listTags[i].Name);
                    values.Add($"{nameof(IFilterListTableEntity.TagDescription)}{indexSuffix}", listTags[i].Description);
                }

                for (var i = 0; i < listUpstreamListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.UpstreamFilterListName)}{indexSuffix}", listUpstreamListNames[i]);
                }

                for (var i = 0; i < listForkListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.ForkFilterListName)}{indexSuffix}", listForkListNames[i]);
                }

                for (var i = 0; i < listIncludedInListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.IncludedInFilterListName)}{indexSuffix}", listIncludedInListNames[i]);
                }

                for (var i = 0; i < listIncludesListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.IncludesFilterListName)}{indexSuffix}", listIncludesListNames[i]);
                }

                for (var i = 0; i < listDependencyListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.DependencyFilterListName)}{indexSuffix}", listDependencyListNames[i]);
                }

                for (var i = 0; i < listDependentListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.DependentFilterListName)}{indexSuffix}", listDependentListNames[i]);
                }

                return new TableEntity(values);
            });

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.FilterListsTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.FilterListsTableName, cancellationToken);
            var tableClient = _tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);

            var transactions = entities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in transactions.Chunk(100))
                await tableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            return new ResponseVm();
        }

        private static async Task<IEnumerable<T>> GetSeedEntities<T>() where T : class
        {
            using var reader = new StreamReader($"{SeedDataDir}{typeof(T).Name}.json");
            var json = await reader.ReadToEndAsync();
            return JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })!;
        }

        // https://stackoverflow.com/a/37749583/2343739
        private static string SanitizeKey(string key, ILogger log)
        {
            if (!DisallowedCharsInTableKeys.IsMatch(key))
                return key;
            var oldKey = key;
            key = key.Replace("+", "&");
            key = key.Replace("/", " & ");
            key = DisallowedCharsInTableKeys.Replace(key, "");
            log.LogWarning(
                "Replaced disallowed characters in Table Storage key. Old: '{oldKey}'. New: '{key}'.",
                oldKey, key);
            return key;
        }
    }

    public record ResponseVm
    {
    }
}