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
    public class SeedService : Service
    {
        public SeedService(FilterListsDbContext dbContext) : base(dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>() where TEntity : class =>
            await DbContext.Set<TEntity>().AsNoTracking().ProjectTo<TSeedDto>().ToArrayAsync();

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort)
            where TEntity : class
        {
            return await DbContext.Set<TEntity>()
                                  .OrderBy(x => primarySort.GetValue(x, null))
                                  .AsNoTracking()
                                  .ProjectTo<TSeedDto>()
                                  .ToArrayAsync();
        }

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort,
            PropertyInfo secondarySort) where TEntity : class
        {
            return await DbContext.Set<TEntity>()
                                  .OrderBy(x => primarySort.GetValue(x, null))
                                  .ThenBy(x => secondarySort.GetValue(x, null))
                                  .AsNoTracking()
                                  .ProjectTo<TSeedDto>()
                                  .ToArrayAsync();
        }
    }
}