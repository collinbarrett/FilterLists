using System.Collections.Generic;
using System.Threading;

namespace FilterLists.Api.FilterLists;

public interface IFilterListRepository
{
    IAsyncEnumerable<FilterListSummaryMobile> GetFilterListSummaryMobilesAsync(CancellationToken token);
}