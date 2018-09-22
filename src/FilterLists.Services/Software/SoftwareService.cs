using System.Collections.Generic;
using System.Linq;
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
                           .OrderBy(s => s.Name)
                           .ProjectTo<SoftwareDto>(MapConfig)
                           .ToListAsync();
    }
}