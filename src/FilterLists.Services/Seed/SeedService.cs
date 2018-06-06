using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Seed
{
    [UsedImplicitly]
    public class SeedService
    {
        private readonly FilterListsDbContext _filterListsDbContext;

        public SeedService(FilterListsDbContext filterListsDbContext)
        {
            _filterListsDbContext = filterListsDbContext;
        }

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>() where TEntity : class =>
            await _filterListsDbContext.Set<TEntity>().AsNoTracking().ProjectTo<TSeedDto>().ToArrayAsync();

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort)
            where TEntity : class
        {
            return await _filterListsDbContext.Set<TEntity>()
                                              .OrderBy(x => primarySort.GetValue(x, null))
                                              .AsNoTracking()
                                              .ProjectTo<TSeedDto>()
                                              .ToArrayAsync();
        }

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort,
            PropertyInfo secondarySort) where TEntity : class
        {
            return await _filterListsDbContext.Set<TEntity>()
                                              .OrderBy(x => primarySort.GetValue(x, null))
                                              .ThenBy(x => secondarySort.GetValue(x, null))
                                              .AsNoTracking()
                                              .ProjectTo<TSeedDto>()
                                              .ToArrayAsync();
        }
    }
}