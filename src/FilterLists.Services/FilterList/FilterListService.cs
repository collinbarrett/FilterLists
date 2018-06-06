using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class FilterListService
    {
        private readonly FilterListsDbContext _filterListsDbContext;

        public FilterListService(FilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync()
        {
            return await _filterListsDbContext.FilterLists.AsNoTracking()
                                              .OrderBy(x => x.Name)
                                              .ProjectTo<ListSummaryDto>()
                                              .ToListAsync();
        }

        public async Task<ListDetailsDto> GetDetailsAsync(int id)
        {
            return await _filterListsDbContext.FilterLists.AsNoTracking()
                                              .ProjectTo<ListDetailsDto>()
                                              .FirstAsync(x => x.Id == id)
                                              .FilterParentListFromMaintainerAdditionalLists();
        }
    }
}