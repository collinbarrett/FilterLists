using System.Collections.Generic;
using System.Threading;
using FilterLists.Api.Api.Lists.GetSummaries.Response;

namespace FilterLists.Api.Infrastructure;

public interface IFilterListRepository
{
    IAsyncEnumerable<FilterListSummaryMobile> GetFilterListSummaryMobilesAsync(CancellationToken token);
}