using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Azure.Data.Tables;
using FilterLists.Api.Api.Lists.GetSummaries.Response;

namespace FilterLists.Api.Infrastructure;

public class FilterListRepository : IFilterListRepository
{
    private readonly TableClient _tableClient;

    public FilterListRepository(TableServiceClient tableServiceClient)
    {
        _tableClient = tableServiceClient.GetTableClient("filterlists");
    }

    public IAsyncEnumerable<FilterListSummaryMobile> GetFilterListSummaryMobilesAsync(
        CancellationToken token)
    {
        return _tableClient.QueryAsync<TableEntity>(
                select: new[] { nameof(TableEntity.RowKey) },
                cancellationToken: token)
            .Select(te => new FilterListSummaryMobile { Name = te.RowKey });
    }
}