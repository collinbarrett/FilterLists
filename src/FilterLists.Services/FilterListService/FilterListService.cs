using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
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
            return await filterListsDbContext.FilterLists
                                             .AsNoTracking()
                                             .OrderBy(x => x.Name)
                                             .ProjectTo<FilterListSummaryDto>()
                                             .ToListAsync();
        }

        public async Task<FilterListDetailsDto> GetDetailsAsync(int id)
        {
            return await filterListsDbContext.FilterLists
                                             .AsNoTracking()
                                             .ProjectTo<FilterListDetailsDto>()
                                             .FirstAsync(x => x.Id == id);
        }
    }
}