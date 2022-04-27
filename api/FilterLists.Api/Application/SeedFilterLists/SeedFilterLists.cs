using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Application.SeedFilterLists.Models;
using FilterLists.Api.Extensions;
using FilterLists.Api.Persistence;
using MediatR;

namespace FilterLists.Api.Application.SeedFilterLists;

public static class SeedFilterLists
{
    public record Command : IRequest<ResponseVm>
    {
    }

    public class Handler : IRequestHandler<Command, ResponseVm>
    {
        private const string SeedDataDir = "../../../../../../FilterLists/services/Directory/data/";
        private readonly TableServiceClient _tableServiceClient;

        public Handler(TableServiceClient tableServiceClient)
        {
            _tableServiceClient = tableServiceClient;
        }

        public async Task<ResponseVm> Handle(Command request, CancellationToken cancellationToken)
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

            var filterListEntities = filterLists.Select(list =>
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
                    .ToList();
                var listForkListNames = filterLists.Where(fl =>
                        forks.Where(fo => fo.UpstreamFilterListId == list.Id)
                            .Select(fo => fo.ForkFilterListId)
                            .Contains(fl.Id))
                    .ToList();
                var listIncludedInListNames = filterLists.Where(fl =>
                        merges.Where(m => m.IncludesFilterListId == list.Id)
                            .Select(m => m.IncludedInFilterListId)
                            .Contains(fl.Id))
                    .ToList();
                var listIncludesListNames = filterLists.Where(fl =>
                        merges.Where(m => m.IncludedInFilterListId == list.Id)
                            .Select(m => m.IncludesFilterListId)
                            .Contains(fl.Id))
                    .ToList();
                var listDependencyListNames = filterLists.Where(fl =>
                        dependents.Where(d => d.DependentFilterListId == list.Id)
                            .Select(d => d.DependencyFilterListId)
                            .Contains(fl.Id))
                    .ToList();
                var listDependentListNames = filterLists.Where(fl =>
                        dependents.Where(d => d.DependencyFilterListId == list.Id)
                            .Select(d => d.DependentFilterListId)
                            .Contains(fl.Id))
                    .ToList();

                var values = new Dictionary<string, object?>
                {
                    { nameof(IFilterListTableEntity.PartitionKey), TableStorageConstants.FilterListsPartitionKey },
                    { nameof(IFilterListTableEntity.RowKey), list.Id.ToTableStorageKeyString() },
                    { nameof(IFilterListTableEntity.Name), list.Name },
                    { nameof(IFilterListTableEntity.Description), list.Description },
                    { nameof(IFilterListTableEntity.HomeUrl), list.HomeUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.OnionUrl), list.OnionUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.PolicyUrl), list.PolicyUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.SubmissionUrl), list.SubmissionUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.IssuesUrl), list.IssuesUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.ForumUrl), list.ForumUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.ChatUrl), list.ChatUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.EmailAddress), list.EmailAddress },
                    { nameof(IFilterListTableEntity.DonateUrl), list.DonateUrl?.ToUrlString() },
                    { nameof(IFilterListTableEntity.LicenseId), listLicense.Id },
                    { nameof(IFilterListTableEntity.LicenseName), listLicense.Name },
                    { nameof(IFilterListTableEntity.LicenseUrl), listLicense.Url?.ToUrlString() },
                    { nameof(IFilterListTableEntity.LicensePermitsModification), listLicense.PermitsModification },
                    { nameof(IFilterListTableEntity.LicensePermitsDistribution), listLicense.PermitsDistribution },
                    { nameof(IFilterListTableEntity.LicensePermitsCommercialUse), listLicense.PermitsCommercialUse }
                };

                for (var i = 0; i < listViewUrls.Count; i++)
                {
                    var indexerSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.ViewUrlSegmentNumber)}{indexerSuffix}", listViewUrls[i].SegmentNumber);
                    values.Add($"{nameof(IFilterListTableEntity.ViewUrlPrimariness)}{indexerSuffix}", listViewUrls[i].Primariness);
                    values.Add($"{nameof(IFilterListTableEntity.ViewUrl)}{indexerSuffix}", listViewUrls[i].Url.ToUrlString());
                }

                for (var i = 0; i < listLanguageIso6391s.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.LanguageIso6391)}{indexSuffix}", listLanguageIso6391s[i].Iso6391);
                    values.Add($"{nameof(IFilterListTableEntity.LanguageName)}{indexSuffix}", listLanguageIso6391s[i].Name);
                }

                for (var i = 0; i < listMaintainers.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerId)}{indexSuffix}", listMaintainers[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerName)}{indexSuffix}", listMaintainers[i].Name);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerUrl)}{indexSuffix}", listMaintainers[i].Url?.ToUrlString());
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerEmailAddress)}{indexSuffix}", listMaintainers[i].EmailAddress);
                    values.Add($"{nameof(IFilterListTableEntity.MaintainerTwitterHandle)}{indexSuffix}", listMaintainers[i].TwitterHandle);
                }

                for (var i = 0; i < listSyntaxes.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxId)}{indexSuffix}", listSyntaxes[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxName)}{indexSuffix}", listSyntaxes[i].Name);
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxDescription)}{indexSuffix}", listSyntaxes[i].Description);
                    values.Add($"{nameof(IFilterListTableEntity.SyntaxUrl)}{indexSuffix}", listSyntaxes[i].Url?.ToUrlString());
                }

                for (var i = 0; i < listSoftware.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareId)}{indexSuffix}", listSoftware[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.SoftwareName)}{indexSuffix}", listSoftware[i].Name);
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
                    values.Add($"{nameof(IFilterListTableEntity.UpstreamFilterListId)}{indexSuffix}", listUpstreamListNames[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.UpstreamFilterListName)}{indexSuffix}", listUpstreamListNames[i].Name);
                }

                for (var i = 0; i < listForkListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.ForkFilterListId)}{indexSuffix}", listForkListNames[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.ForkFilterListName)}{indexSuffix}", listForkListNames[i].Name);
                }

                for (var i = 0; i < listIncludedInListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.IncludedInFilterListId)}{indexSuffix}", listIncludedInListNames[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.IncludedInFilterListName)}{indexSuffix}", listIncludedInListNames[i].Name);
                }

                for (var i = 0; i < listIncludesListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.IncludesFilterListId)}{indexSuffix}", listIncludesListNames[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.IncludesFilterListName)}{indexSuffix}", listIncludesListNames[i].Name);
                }

                for (var i = 0; i < listDependencyListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.DependencyFilterListId)}{indexSuffix}", listDependencyListNames[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.DependencyFilterListName)}{indexSuffix}", listDependencyListNames[i].Name);
                }

                for (var i = 0; i < listDependentListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add($"{nameof(IFilterListTableEntity.DependentFilterListId)}{indexSuffix}", listDependentListNames[i].Id);
                    values.Add($"{nameof(IFilterListTableEntity.DependentFilterListName)}{indexSuffix}", listDependentListNames[i].Name);
                }

                return new TableEntity(values);
            });

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.FilterListsTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.FilterListsTableName, cancellationToken);
            var tableClient = _tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);

            var transactions = filterListEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in transactions.Chunk(100))
                await tableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            // TODO: seed languages table
            // TODO: seed licenses table
            // TODO: seed maintainers table
            // TODO: seed syntaxes table
            // TODO: seed software table
            // TODO: seed tags table

            return new ResponseVm();
        }

        private static async Task<IEnumerable<T>> GetSeedEntities<T>() where T : class
        {
            using var reader = new StreamReader($"{SeedDataDir}{typeof(T).Name}.json");
            var json = await reader.ReadToEndAsync();
            return JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })!;
        }
    }

    public record ResponseVm
    {
    }
}