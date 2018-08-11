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
        public SeedService(FilterListsDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>() where TEntity : class =>
            await DbContext.Set<TEntity>().ProjectTo<TSeedDto>(Mapper.ConfigurationProvider).ToArrayAsync();

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort)
            where TEntity : class =>
            await DbContext.Set<TEntity>()
                           .OrderBy(x => primarySort.GetValue(x, null))
                           .ProjectTo<TSeedDto>(Mapper.ConfigurationProvider)
                           .ToArrayAsync();

        public async Task<IEnumerable<TSeedDto>> GetAllAsync<TEntity, TSeedDto>(PropertyInfo primarySort,
            PropertyInfo secondarySort) where TEntity : class =>
            await DbContext.Set<TEntity>()
                           .OrderBy(x => primarySort.GetValue(x, null))
                           .ThenBy(x => secondarySort.GetValue(x, null))
                           .ProjectTo<TSeedDto>(Mapper.ConfigurationProvider)
                           .ToArrayAsync();
    }
}