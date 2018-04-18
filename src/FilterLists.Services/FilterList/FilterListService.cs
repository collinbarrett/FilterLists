using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    public class FilterListService
    {
        private readonly FilterListsDbContext filterListsDbContext;

        public FilterListService(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync()
        {
            return await filterListsDbContext.FilterLists
                                             .AsNoTracking()
                                             .OrderBy(x => x.Name)
                                             .ProjectTo<ListSummaryDto>()
                                             .ToListAsync();
        }

        public async Task<ListDetailsDto> GetDetailsAsync(int id)
        {
            return await filterListsDbContext.FilterLists
                                             .AsNoTracking()
                                             .ProjectTo<ListDetailsDto>()
                                             .FirstAsync(x => x.Id == id)
                                             .FilterParentListFromMaintainerAdditionalLists();
        }
    }
}