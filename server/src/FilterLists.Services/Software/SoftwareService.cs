using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.Software.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Software
{
    [UsedImplicitly]
    public class SoftwareService : Service
    {
        public SoftwareService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<SoftwareDto>> GetAll() =>
            await DbContext.Software
                           .ProjectTo<SoftwareDto>(MapConfig)
                           .ToListAsync();

        public async Task<SoftwareDto> GetById(int id) =>
            await DbContext.Software
                           .ProjectTo<SoftwareDto>(MapConfig)
                           .FirstOrDefaultAsync(s => s.Id == id);
    }
}