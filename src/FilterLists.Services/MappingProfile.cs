using AutoMapper.Configuration;
using FilterLists.Data.Entities;
using FilterLists.Services.Models;

namespace FilterLists.Services
{
    public class MappingProfile : MapperConfigurationExpression
    {
        public MappingProfile()
        {
            CreateMap<FilterList, FilterListSummaryDto>();
            CreateMap<FilterList, FilterListSeedDto>();
        }
    }
}