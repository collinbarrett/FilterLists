using System.Collections.Generic;
using System.Linq;
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

        private IQueryable<Data.Entities.Maintainer> MaintainsAnyLists =>
            DbContext.Maintainers.Where(m => m.FilterListMaintainers.Any());

        public async Task<IEnumerable<MaintainerDto>> GetAllThatMaintainAnyListAsync() =>
            await MaintainsAnyLists.ProjectTo<MaintainerDto>(MapConfig)
                                   .ToListAsync();

        public async Task<MaintainerDto> GetIfMaintainsAnyListByIdAsync(int id) =>
            await MaintainsAnyLists.ProjectTo<MaintainerDto>(MapConfig)
                                   .FirstOrDefaultAsync(m => m.Id == id);
    }
}