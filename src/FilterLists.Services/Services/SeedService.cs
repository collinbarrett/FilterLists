using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FilterLists.Data;
using FilterLists.Data.Entities;
using FilterLists.Services.Models.Seed;

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
            return await Task.FromResult(
                mapper.Map<IEnumerable<FilterListSeedDto>>(filterListsDbContext.Set<FilterList>()));
        }

        public async Task<IEnumerable<LanguageSeedDto>> GetAllLanguages()
        {
            return await Task.FromResult(
                mapper.Map<IEnumerable<LanguageSeedDto>>(filterListsDbContext.Set<Language>()));
        }

        public async Task<IEnumerable<LicenseSeedDto>> GetAllLicenses()
        {
            return await Task.FromResult(mapper.Map<IEnumerable<LicenseSeedDto>>(filterListsDbContext.Set<License>()));
        }

        public async Task<IEnumerable<MaintainerSeedDto>> GetAllMaintainers()
        {
            return await Task.FromResult(
                mapper.Map<IEnumerable<MaintainerSeedDto>>(filterListsDbContext.Set<Maintainer>()));
        }

        public async Task<IEnumerable<SoftwareSeedDto>> GetAllSoftware()
        {
            return await Task.FromResult(
                mapper.Map<IEnumerable<SoftwareSeedDto>>(filterListsDbContext.Set<Software>()));
        }

        public async Task<IEnumerable<SyntaxSeedDto>> GetAllSyntaxes()
        {
            return await Task.FromResult(mapper.Map<IEnumerable<SyntaxSeedDto>>(filterListsDbContext.Set<Syntax>()));
        }
    }
}