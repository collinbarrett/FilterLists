using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Azure.Data.Tables;
using FilterLists.Api.Application.Lists.GetSummaries.Response;
using FilterLists.Api.Extensions;

namespace FilterLists.Api.Infrastructure;

public class FilterListRepository : IFilterListRepository
{
    private const int MaxDenormalizedIndexCount = 30;
    private readonly TableClient _tableClient;

    public FilterListRepository(TableServiceClient tableServiceClient)
    {
        _tableClient = tableServiceClient.GetTableClient("filterlists");
    }

    public IAsyncEnumerable<FilterListSummary> GetFilterListSummariesAsync(
        CancellationToken token)
    {
        var indices = Enumerable.Range(0, MaxDenormalizedIndexCount - 1).Select(IntExtensions.ToIndexSuffix).ToList();

        var select = new List<string>
        {
            nameof(TableEntity.RowKey),
            nameof(IFilterListTableEntity.Description),
            nameof(IFilterListTableEntity.LicenseName)
        };

        select.AddRange(indices.Select(i => $"{nameof(IFilterListTableEntity.SoftwareName)}{i}"));
        select.AddRange(indices.Select(i => $"{nameof(IFilterListTableEntity.SyntaxName)}{i}"));
        select.AddRange(indices.Select(i => $"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}"));
        select.AddRange(indices.Select(i => $"{nameof(IFilterListTableEntity.TagName)}{i}"));
        select.AddRange(indices.Select(i => $"{nameof(IFilterListTableEntity.MaintainerName)}{i}"));

        return _tableClient.QueryAsync<TableEntity>(select: select, cancellationToken: token)
            .Select(te => new FilterListSummary
            {
                Name = te.RowKey,
                Description = te.GetString(nameof(IFilterListTableEntity.Description)),
                Software = indices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.SoftwareName)}{i}"))
                    .Where(s => s is not null),
                Syntaxes = indices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.SyntaxName)}{i}"))
                    .Where(s => s is not null),
                Languages = indices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.LanguageIso6391)}{i}"))
                    .Where(s => s is not null),
                Tags = indices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.TagName)}{i}"))
                    .Where(s => s is not null),
                Maintainers = indices.Select(i => te.GetString($"{nameof(IFilterListTableEntity.MaintainerName)}{i}"))
                    .Where(s => s is not null),
                License = te.GetString(nameof(IFilterListTableEntity.LicenseName))
            });
    }

    public IAsyncEnumerable<FilterListSummaryLight> GetFilterListLightSummariesAsync(
        CancellationToken token)
    {
        return _tableClient.QueryAsync<TableEntity>(
                select: new[] { nameof(TableEntity.RowKey) },
                cancellationToken: token)
            .Select(te => new FilterListSummaryLight { Name = te.RowKey });
    }
}