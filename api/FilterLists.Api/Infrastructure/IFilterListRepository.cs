using System.Collections.Generic;
using System.Threading;
using FilterLists.Api.Application.Lists.GetSummaries.Response;

namespace FilterLists.Api.Infrastructure;

public interface IFilterListRepository
{
    IAsyncEnumerable<FilterListSummary> GetFilterListSummariesAsync(CancellationToken token);
    IAsyncEnumerable<FilterListSummaryLight> GetFilterListLightSummariesAsync(CancellationToken token);
}