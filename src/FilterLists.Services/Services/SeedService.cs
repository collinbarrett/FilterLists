using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Services.Services
{
    public class SeedService
    {
        private readonly FilterListsDbContext filterListsDbContext;
        private readonly IMapper mapper;

        public SeedService(FilterListsDbContext filterListsDbContext, IMapper mapper)
        {
            this.filterListsDbContext = filterListsDbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<FilterListSeedDto>> GetAllFilterLists()
        {
            return await filterListsDbContext.Set<FilterList>().ProjectTo<FilterListSeedDto>().ToListAsync();
        }

        public async Task<IEnumerable<LanguageSeedDto>> GetAllLanguages()
        {
            return await filterListsDbContext.Set<Language>().ProjectTo<LanguageSeedDto>().ToListAsync();
        }

        public async Task<IEnumerable<LicenseSeedDto>> GetAllLicenses()
        {
            return await filterListsDbContext.Set<License>().ProjectTo<LicenseSeedDto>().ToListAsync();
        }

        public async Task<IEnumerable<MaintainerSeedDto>> GetAllMaintainers()
        {
            return await filterListsDbContext.Set<Maintainer>().ProjectTo<MaintainerSeedDto>().ToListAsync();
        }

        public async Task<IEnumerable<SoftwareSeedDto>> GetAllSoftware()
        {
            return await filterListsDbContext.Set<Software>().ProjectTo<SoftwareSeedDto>().ToListAsync();
        }

        public async Task<IEnumerable<SyntaxSeedDto>> GetAllSyntaxes()
        {
            return await filterListsDbContext.Set<Syntax>().ProjectTo<SyntaxSeedDto>().ToListAsync();
        }
    }
}