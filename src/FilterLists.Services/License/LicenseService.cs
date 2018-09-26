using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Services.License.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.License
{
    [UsedImplicitly]
    public class LicenseService : Service
    {
        public LicenseService(FilterListsDbContext dbContext, IConfigurationProvider mapConfig)
            : base(dbContext, mapConfig)
        {
        }

        public async Task<IEnumerable<LicenseDto>> GetAllAsync() =>
            await DbContext.Licenses
                           .ProjectTo<LicenseDto>(MapConfig)
                           .ToListAsync();

        public async Task<LicenseDto> GetByIdAsync(int id) =>
            await DbContext.Licenses
                           .ProjectTo<LicenseDto>(MapConfig)
                           .FirstOrDefaultAsync(l => l.Id == id);
    }
}