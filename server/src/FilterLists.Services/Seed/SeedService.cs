using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Seed
{
    [UsedImplicitly]
    public class SeedService : Service
    {
        public SeedService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>() where TEntity : class =>
            await DbContext.Set<TEntity>().ProjectTo<TSeedDto>(MapConfig).ToListAsync();

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort,
            PropertyInfo secondarySort)
            where TEntity : class =>
            (await DbContext.Set<TEntity>().ToListAsync())
                        .AsQueryable()
                        .OrderBy(s => primarySort.GetValue(s, null))
                        .ThenBy(s => secondarySort.GetValue(s, null))
                        .ProjectTo<TSeedDto>(MapConfig)
                        .ToList();
    }
}