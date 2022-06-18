using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;
using FilterLists.Api.Application.SeedFilterLists.Models;
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
            var filterLists = (await GetSeedEntities<FilterList>()).ToList();
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
            var syntaxes = (await GetSeedEntities<Syntax>()).ToList();
            var tags = await GetSeedEntities<Tag>();

            var filterListEntities = filterLists.ConvertAll(list =>
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
                    values.Add(nameof(IFilterListTableEntity.ViewUrlSegmentNumber) + indexerSuffix, listViewUrls[i].SegmentNumber);
                    values.Add(nameof(IFilterListTableEntity.ViewUrlPrimariness) + indexerSuffix, listViewUrls[i].Primariness);
                    values.Add(nameof(IFilterListTableEntity.ViewUrl) + indexerSuffix, listViewUrls[i].Url.ToUrlString());
                }

                for (var i = 0; i < listLanguageIso6391s.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.LanguageIso6391) + indexSuffix, listLanguageIso6391s[i].Iso6391);
                    values.Add(nameof(IFilterListTableEntity.LanguageName) + indexSuffix, listLanguageIso6391s[i].Name);
                }

                for (var i = 0; i < listMaintainers.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.MaintainerId) + indexSuffix, listMaintainers[i].Id);
                    values.Add(nameof(IFilterListTableEntity.MaintainerName) + indexSuffix, listMaintainers[i].Name);
                    values.Add(nameof(IFilterListTableEntity.MaintainerUrl) + indexSuffix, listMaintainers[i].Url?.ToUrlString());
                    values.Add(nameof(IFilterListTableEntity.MaintainerEmailAddress) + indexSuffix, listMaintainers[i].EmailAddress);
                    values.Add(nameof(IFilterListTableEntity.MaintainerTwitterHandle) + indexSuffix, listMaintainers[i].TwitterHandle);
                }

                for (var i = 0; i < listSyntaxes.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.SyntaxId) + indexSuffix, listSyntaxes[i].Id);
                    values.Add(nameof(IFilterListTableEntity.SyntaxName) + indexSuffix, listSyntaxes[i].Name);
                    values.Add(nameof(IFilterListTableEntity.SyntaxDescription) + indexSuffix, listSyntaxes[i].Description);
                    values.Add(nameof(IFilterListTableEntity.SyntaxUrl) + indexSuffix, listSyntaxes[i].Url?.ToUrlString());
                }

                for (var i = 0; i < listSoftware.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.SoftwareId) + indexSuffix, listSoftware[i].Id);
                    values.Add(nameof(IFilterListTableEntity.SoftwareName) + indexSuffix, listSoftware[i].Name);
                }

                for (var i = 0; i < listTags.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.TagId) + indexSuffix, listTags[i].Id);
                    values.Add(nameof(IFilterListTableEntity.TagName) + indexSuffix, listTags[i].Name);
                    values.Add(nameof(IFilterListTableEntity.TagDescription) + indexSuffix, listTags[i].Description);
                }

                for (var i = 0; i < listUpstreamListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.UpstreamFilterListId) + indexSuffix, listUpstreamListNames[i].Id);
                    values.Add(nameof(IFilterListTableEntity.UpstreamFilterListName) + indexSuffix, listUpstreamListNames[i].Name);
                }

                for (var i = 0; i < listForkListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.ForkFilterListId) + indexSuffix, listForkListNames[i].Id);
                    values.Add(nameof(IFilterListTableEntity.ForkFilterListName) + indexSuffix, listForkListNames[i].Name);
                }

                for (var i = 0; i < listIncludedInListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.IncludedInFilterListId) + indexSuffix, listIncludedInListNames[i].Id);
                    values.Add(nameof(IFilterListTableEntity.IncludedInFilterListName) + indexSuffix, listIncludedInListNames[i].Name);
                }

                for (var i = 0; i < listIncludesListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.IncludesFilterListId) + indexSuffix, listIncludesListNames[i].Id);
                    values.Add(nameof(IFilterListTableEntity.IncludesFilterListName) + indexSuffix, listIncludesListNames[i].Name);
                }

                for (var i = 0; i < listDependencyListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.DependencyFilterListId) + indexSuffix, listDependencyListNames[i].Id);
                    values.Add(nameof(IFilterListTableEntity.DependencyFilterListName) + indexSuffix, listDependencyListNames[i].Name);
                }

                for (var i = 0; i < listDependentListNames.Count; i++)
                {
                    var indexSuffix = i.ToIndexSuffix();
                    values.Add(nameof(IFilterListTableEntity.DependentFilterListId) + indexSuffix, listDependentListNames[i].Id);
                    values.Add(nameof(IFilterListTableEntity.DependentFilterListName) + indexSuffix, listDependentListNames[i].Name);
                }

                return new TableEntity(values);
            });

            #region Sample Full FilterList

            var sampleValues = new Dictionary<string, object>
            {
                { nameof(IFilterListTableEntity.PartitionKey), TableStorageConstants.FilterListsPartitionKey },
                { nameof(IFilterListTableEntity.RowKey), 1000000L.ToTableStorageKeyString() },
                { nameof(IFilterListTableEntity.Name), "1 Collin's Sample list" },
                { nameof(IFilterListTableEntity.Description), "A sample list to test the proper display of a list containing all values. This is not an actual list. This is a fake list. How does the UI look?" },
                { nameof(IFilterListTableEntity.HomeUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.OnionUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.PolicyUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.SubmissionUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.IssuesUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.ForumUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.ChatUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.EmailAddress), "hi@filterlists.com" },
                { nameof(IFilterListTableEntity.DonateUrl), "https://github.com/collinbarrett/filterlists" },
                { nameof(IFilterListTableEntity.LicenseId), 35L },
                { nameof(IFilterListTableEntity.LicenseName), "Dandelicence" },
                { nameof(IFilterListTableEntity.LicenseUrl), "https://github.com/DandelionSprout/Dandelicence/blob/master/DandelicenceNewestVersion.md" },
                { nameof(IFilterListTableEntity.LicensePermitsModification), true },
                { nameof(IFilterListTableEntity.LicensePermitsDistribution), false },
                { nameof(IFilterListTableEntity.LicensePermitsCommercialUse), true }
            };

            for (var i = 0; i < 3; i++)
            {
                var indexerSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.ViewUrlSegmentNumber) + indexerSuffix, i);
                sampleValues.Add(nameof(IFilterListTableEntity.ViewUrlPrimariness) + indexerSuffix, 1);
                sampleValues.Add(nameof(IFilterListTableEntity.ViewUrl) + indexerSuffix, "https://github.com/collinbarrett/filterlists");
            }

            for (var i = 3; i < 6; i++)
            {
                var indexerSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.ViewUrlSegmentNumber) + indexerSuffix, i - 3);
                sampleValues.Add(nameof(IFilterListTableEntity.ViewUrlPrimariness) + indexerSuffix, 2);
                sampleValues.Add(nameof(IFilterListTableEntity.ViewUrl) + indexerSuffix, "https://github.com/collinbarrett/filterlists");
            }

            for (var i = 0; i < 12; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.LanguageIso6391) + indexSuffix, "en");
                sampleValues.Add(nameof(IFilterListTableEntity.LanguageName) + indexSuffix, "English");
            }

            for (var i = 0; i < 6; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.MaintainerId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.MaintainerName) + indexSuffix, "Collin Barrett");
                sampleValues.Add(nameof(IFilterListTableEntity.MaintainerUrl) + indexSuffix, "https://github.com/collinbarrett/filterlists");
                sampleValues.Add(nameof(IFilterListTableEntity.MaintainerEmailAddress) + indexSuffix, "hi@filterlists.com");
                sampleValues.Add(nameof(IFilterListTableEntity.MaintainerTwitterHandle) + indexSuffix, "collinbarrett");
            }

            for (var i = 0; i < 8; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.SyntaxId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.SyntaxName) + indexSuffix, "Hosts");
                sampleValues.Add(nameof(IFilterListTableEntity.SyntaxDescription) + indexSuffix, "A syntax of IPs in IPv4 and IPv6 formats. Used in a variety of sotware. A common syntax");
                sampleValues.Add(nameof(IFilterListTableEntity.SyntaxUrl) + indexSuffix, "https://github.com/collinbarrett/filterlists");
            }

            for (var i = 0; i < 33; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.SoftwareId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.SoftwareName) + indexSuffix, "uBlock Origin");
            }

            for (var i = 0; i < 15; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.TagId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.TagName) + indexSuffix, "ads");
                sampleValues.Add(nameof(IFilterListTableEntity.TagDescription) + indexSuffix, "Blocks advertisements");
            }

            for (var i = 0; i < 10; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.UpstreamFilterListId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.UpstreamFilterListName) + indexSuffix, "1 Collin's Sample list");
            }

            for (var i = 0; i < 10; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.ForkFilterListId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.ForkFilterListName) + indexSuffix, "1 Collin's Sample list");
            }

            for (var i = 0; i < 10; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.IncludedInFilterListId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.IncludedInFilterListName) + indexSuffix, "1 Collin's Sample list");
            }

            for (var i = 0; i < 10; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.IncludesFilterListId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.IncludesFilterListName) + indexSuffix, "1 Collin's Sample list");
            }

            for (var i = 0; i < 10; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.DependencyFilterListId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.DependencyFilterListName) + indexSuffix, "1 Collin's Sample list");
            }

            for (var i = 0; i < 10; i++)
            {
                var indexSuffix = i.ToIndexSuffix();
                sampleValues.Add(nameof(IFilterListTableEntity.DependentFilterListId) + indexSuffix, 1L);
                sampleValues.Add(nameof(IFilterListTableEntity.DependentFilterListName) + indexSuffix, "1 Collin's Sample list");
            }

            var sampleFilterListEntity = new TableEntity(sampleValues);
            filterListEntities.Add(sampleFilterListEntity);

            #endregion Sample Full FilterList

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.FilterListsTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.FilterListsTableName, cancellationToken);
            var filterListsTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.FilterListsTableName);

            var filterListTransactions = filterListEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in filterListTransactions.Chunk(100))
                await filterListsTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var languageEntities = languages.Select(l => new TableEntity(new Dictionary<string, object?>
            {
                { nameof(ILanguageTableEntity.PartitionKey), TableStorageConstants.LanguagesPartitionKey },
                { nameof(ILanguageTableEntity.RowKey), l.Iso6391 },
                { nameof(ILanguageTableEntity.Name), l.Name }
            }));

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.LanguagesTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.LanguagesTableName, cancellationToken);
            var languagesTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.LanguagesTableName);

            var languageTransactions = languageEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in languageTransactions.Chunk(100))
                await languagesTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var licenseEntities = licenses.Select(l => new TableEntity(new Dictionary<string, object?>
            {
                { nameof(ILicenseTableEntity.PartitionKey), TableStorageConstants.LicensesPartitionKey },
                { nameof(ILicenseTableEntity.RowKey), l.Id.ToTableStorageKeyString() },
                { nameof(ILicenseTableEntity.Name), l.Name },
                { nameof(ILicenseTableEntity.Url), l.Url?.ToUrlString() },
                { nameof(ILicenseTableEntity.PermitsModification), l.PermitsModification },
                { nameof(ILicenseTableEntity.PermitsDistribution), l.PermitsDistribution },
                { nameof(ILicenseTableEntity.PermitsCommercialUse), l.PermitsCommercialUse }
            }));

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.LicensesTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.LicensesTableName, cancellationToken);
            var licensesTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.LicensesTableName);

            var licenseTransactions = licenseEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in licenseTransactions.Chunk(100))
                await licensesTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var maintainerEntities = maintainers.Select(m => new TableEntity(new Dictionary<string, object?>
            {
                { nameof(IMaintainerTableEntity.PartitionKey), TableStorageConstants.MaintainersPartitionKey },
                { nameof(IMaintainerTableEntity.RowKey), m.Id.ToTableStorageKeyString() },
                { nameof(IMaintainerTableEntity.Name), m.Name },
                { nameof(IMaintainerTableEntity.Url), m.Url?.ToUrlString() },
                { nameof(IMaintainerTableEntity.EmailAddress), m.EmailAddress },
                { nameof(IMaintainerTableEntity.TwitterHandle), m.TwitterHandle }
            }));

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.MaintainersTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.MaintainersTableName, cancellationToken);
            var maintainersTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.MaintainersTableName);

            var maintainerTransactions = maintainerEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in maintainerTransactions.Chunk(100))
                await maintainersTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var syntaxEntities = syntaxes.Select(s => new TableEntity(new Dictionary<string, object?>
            {
                { nameof(ISyntaxTableEntity.PartitionKey), TableStorageConstants.SyntaxesPartitionKey },
                { nameof(ISyntaxTableEntity.RowKey), s.Id.ToTableStorageKeyString() },
                { nameof(ISyntaxTableEntity.Name), s.Name },
                { nameof(ISyntaxTableEntity.Description), s.Description },
                { nameof(ISyntaxTableEntity.Url), s.Url?.ToUrlString() }
            }));

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.SyntaxesTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.SyntaxesTableName, cancellationToken);
            var syntaxesTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.SyntaxesTableName);

            var syntaxTransactions = syntaxEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in syntaxTransactions.Chunk(100))
                await syntaxesTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var softwareEntities = software.Select(s => new TableEntity(new Dictionary<string, object?>
            {
                { nameof(ISoftwareTableEntity.PartitionKey), TableStorageConstants.SoftwarePartitionKey },
                { nameof(ISoftwareTableEntity.RowKey), s.Id.ToTableStorageKeyString() },
                { nameof(ISoftwareTableEntity.Name), s.Name },
                { nameof(ISoftwareTableEntity.Description), s.Description },
                { nameof(ISoftwareTableEntity.HomeUrl), s.HomeUrl?.ToUrlString() },
                { nameof(ISoftwareTableEntity.DownloadUrl), s.DownloadUrl?.ToUrlString() },
                { nameof(ISoftwareTableEntity.SupportsAbpUrlScheme), s.SupportsAbpUrlScheme }
            }));

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.SoftwareTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.SoftwareTableName, cancellationToken);
            var softwareTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.SoftwareTableName);

            var softwareTransactions = softwareEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in softwareTransactions.Chunk(100))
                await softwareTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var softwareSyntaxEntities = softwareSyntaxes.Select(ss =>
            {
                var syntax = syntaxes.Single(s => s.Id == ss.SyntaxId);
                return new TableEntity(new Dictionary<string, object?>
                {
                    { nameof(ISoftwareSyntaxTableEntity.PartitionKey), TableStorageConstants.SoftwarePartitionKey },
                    { nameof(ISoftwareSyntaxTableEntity.RowKey), $"{ss.SoftwareId.ToTableStorageKeyString()}_{ss.SyntaxId.ToTableStorageKeyString()}" },
                    { nameof(ISoftwareSyntaxTableEntity.SyntaxName), syntax.Name },
                    { nameof(ISoftwareSyntaxTableEntity.SyntaxDescription), syntax.Description },
                    { nameof(ISoftwareSyntaxTableEntity.SyntaxUrl), syntax.Url?.ToUrlString() }
                });
            });

            var softwareSyntaxTransactions = softwareSyntaxEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in softwareSyntaxTransactions.Chunk(100))
                await softwareTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

            var tagEntities = tags.Select(t => new TableEntity(new Dictionary<string, object?>
            {
                { nameof(ITagTableEntity.PartitionKey), TableStorageConstants.TagsPartitionKey },
                { nameof(ITagTableEntity.RowKey), t.Id.ToTableStorageKeyString() },
                { nameof(ITagTableEntity.Name), t.Name },
                { nameof(ITagTableEntity.Description), t.Description }
            }));

            await _tableServiceClient.DeleteTableAsync(TableStorageConstants.TagsTableName, cancellationToken);
            Thread.Sleep(40 * 1000); // https://docs.microsoft.com/en-us/rest/api/storageservices/Delete-Table?redirectedfrom=MSDN#remarks
            await _tableServiceClient.CreateTableAsync(TableStorageConstants.TagsTableName, cancellationToken);
            var tagsTableClient = _tableServiceClient.GetTableClient(TableStorageConstants.TagsTableName);

            var tagTransactions = tagEntities.Select(e => new TableTransactionAction(TableTransactionActionType.Add, e));
            foreach (var transactionBatch in tagTransactions.Chunk(100))
                await tagsTableClient.SubmitTransactionAsync(transactionBatch, cancellationToken);

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