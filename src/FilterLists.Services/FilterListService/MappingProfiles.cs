using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;

namespace FilterLists.Services.FilterListService
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<FilterList, FilterListDetailsDto>()
                .ForMember(d => d.Languages,
                    opt => opt.MapFrom(c => c.FilterListLanguages.Select(x => x.Language.Name)));
        }
    }
}