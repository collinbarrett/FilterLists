using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListMaintainerDtoMappingProfile : Profile
    {
        public ListMaintainerDtoMappingProfile() =>
            CreateMap<Maintainer, ListMaintainerDto>()
                .ForMember(d => d.AdditionalLists,
                    c => c.MapFrom(m => m.FilterListMaintainers.Select(lm => lm.FilterList)));
    }
}