using System.Linq;
using AutoMapper;
using FilterLists.Services.Maintainer.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.Maintainer.MappingProfiles
{
    [UsedImplicitly]
    public class MaintainerDtoMappingProfile : Profile
    {
        public MaintainerDtoMappingProfile() =>
            CreateMap<Data.Entities.Maintainer, MaintainerDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        src.Id))
                .ForMember(dest => dest.FilterListIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListMaintainers
                           .Select(fm => fm.FilterListId)));
    }
}