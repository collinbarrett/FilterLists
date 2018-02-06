using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterListService
{
    public class FilterListService
    {
        private readonly FilterListsDbContext filterListsDbContext;

        public FilterListService(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public async Task<IEnumerable<FilterListSummaryDto>> GetAllSummariesAsync()
        {
            return await filterListsDbContext.Set<FilterList>()
                                             .AsNoTracking()
                                             .OrderBy(x => x.Name)
                                             .ProjectTo<FilterListSummaryDto>()
                                             .ToListAsync();
        }
    }
}