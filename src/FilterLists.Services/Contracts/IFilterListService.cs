using System.Collections.Generic;
using FilterLists.Services.Models;

namespace FilterLists.Services.Contracts
{
    public interface IFilterListService
    {
        IEnumerable<FilterListSummaryDto> GetAllSummaries();
    }
}