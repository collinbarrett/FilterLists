using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.FilterList.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.FilterList
{
    public class FilterListService : Service
    {
        public FilterListService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<ListSummaryDto>> GetAllSummariesAsync() =>
            await DbContext.FilterLists
                           .OrderBy(l => l.Name)
                           .ProjectTo<ListSummaryDto>(MapConfig)
                           .ToListAsync();

        public async Task<IEnumerable<ListIndexRecord>> GetIndexAsync() =>
            await DbContext.FilterLists
                           .OrderBy(l => l.Name)
                           .ProjectTo<ListIndexRecord>(MapConfig)
                           .ToListAsync();

        public async Task<ListDetailsDto> GetDetailsAsync(uint id) =>
            await DbContext.FilterLists.ProjectTo<ListDetailsDto>(MapConfig)
                           .FirstOrDefaultAsync(x => x.Id == id)
                           .FilterParentListFromMaintainerAdditionalLists();
    }
}