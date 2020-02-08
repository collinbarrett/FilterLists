using System.Collections.Generic;
using System.Linq;
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

        private IQueryable<Data.Entities.License> ImplementedLicenses =>
            DbContext.Licenses.Where(l => l.FilterLists.Any());

        public async Task<IEnumerable<LicenseDto>> GetAllImplementedAsync() =>
            await ImplementedLicenses.ProjectTo<LicenseDto>(MapConfig)
                                     .ToListAsync();

        public async Task<LicenseDto> GetImplementedByIdAsync(int id) =>
            await ImplementedLicenses.ProjectTo<LicenseDto>(MapConfig)
                                     .FirstOrDefaultAsync(l => l.Id == id);
    }
}