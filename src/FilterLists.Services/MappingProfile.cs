using AutoMapper.Configuration;
using FilterLists.Data.Entities;
using FilterLists.Services.Models;
using FilterLists.Services.Models.Seed;

namespace FilterLists.Services
{
    public class MappingProfile : MapperConfigurationExpression
    {
        public MappingProfile()
        {
            CreateMap<FilterList, FilterListSummaryDto>();
            MapSeedDtos();
        }

        private void MapSeedDtos()
        {
            CreateMap<FilterList, FilterListSeedDto>();
            CreateMap<Language, LanguageSeedDto>();
            CreateMap<License, LicenseSeedDto>();
            CreateMap<Maintainer, MaintainerSeedDto>();
            CreateMap<Software, SoftwareSeedDto>();
            CreateMap<Syntax, SyntaxSeedDto>();
        }
    }
}