using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Data.Tables;

namespace FilterLists.Api.FilterLists;

public interface IFilterListRepository
{
    Task<IEnumerable<FilterList>> GetListsAsync(CancellationToken cancellationToken);
}

public class FilterListRepository : IFilterListRepository
{
    private readonly TableClient _tableClient;

    public FilterListRepository(TableServiceClient tableServiceClient)
    {
        _tableClient = tableServiceClient.GetTableClient("filterlists");
    }

    public async Task<IEnumerable<FilterList>> GetListsAsync(CancellationToken cancellationToken)
    {
        return await _tableClient.QueryAsync<FilterList>(cancellationToken: cancellationToken)
            .ToListAsync(cancellationToken);
    }
}