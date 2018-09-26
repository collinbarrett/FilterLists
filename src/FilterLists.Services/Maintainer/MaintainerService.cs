using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Maintainer.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Maintainer
{
    [UsedImplicitly]
    public class MaintainerService : Service
    {
        public MaintainerService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<MaintainerDto>> GetAllAsync() =>
            await DbContext.Maintainers
                           .ProjectTo<MaintainerDto>(MapConfig)
                           .ToListAsync();

        public async Task<MaintainerDto> GetByIdAsync(int id) =>
            await DbContext.Maintainers
                           .ProjectTo<MaintainerDto>(MapConfig)
                           .FirstOrDefaultAsync(m => m.Id == id);
    }
}