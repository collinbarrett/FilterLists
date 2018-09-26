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
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id))
                .ForMember(dest => dest.AdditionalLists,
                    opt => opt.MapFrom(src =>
                        src.FilterListMaintainers.Select(lm => lm.FilterList)));
    }
}