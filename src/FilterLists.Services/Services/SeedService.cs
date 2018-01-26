using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Services
{
    public class SeedService
    {
        private readonly FilterListsDbContext filterListsDbContext;

        public SeedService(FilterListsDbContext filterListsDbContext)
        {
            this.filterListsDbContext = filterListsDbContext;
        }

        public async Task<IEnumerable<TMapped>> GetAll<TEntity, TMapped>() where TEntity : class
        {
            return await filterListsDbContext.Set<TEntity>().AsNoTracking().ProjectTo<TMapped>().ToArrayAsync();
        }
    }
}