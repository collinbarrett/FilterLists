using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.List.Models;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.List
{
    public class ListService : Service
    {
        public ListService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<Models.List>> GetAllAsync() =>
            await DbContext.FilterLists
                           .OrderBy(l => l.Name)
                           .ProjectTo<Models.List>(MapConfig)
                           .ToListAsync();

        public async Task<ListDetails> GetDetailsAsync(int id) =>
            await DbContext.FilterLists
                           .ProjectTo<ListDetails>(MapConfig)
                           .FirstOrDefaultAsync(x => x.Id == id)
                           .FilterParentListFromMaintainerAdditionalLists();
    }
}