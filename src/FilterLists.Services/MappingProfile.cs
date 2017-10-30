using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.Models;

namespace FilterLists.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FilterList, FilterListSummaryDto>();
        }
    }
}