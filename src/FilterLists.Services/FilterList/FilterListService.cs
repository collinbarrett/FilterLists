using System.Collections.Generic;
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

        public async Task<IEnumerable<FilterListDto>> GetAllAsync() =>
            await DbContext.FilterLists
                           .ProjectTo<FilterListDto>(MapConfig)
                           .ToListAsync();

        public async Task<ListDetails> GetDetailsAsync(int id) =>
            await DbContext.FilterLists
                           .ProjectTo<ListDetails>(MapConfig)
                           .FirstOrDefaultAsync(l => l.Id == id)
                           .FilterParentListFromMaintainerAdditionalLists();
    }
}