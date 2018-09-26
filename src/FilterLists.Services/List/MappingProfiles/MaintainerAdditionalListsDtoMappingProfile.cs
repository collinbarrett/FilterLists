using AutoMapper;
using FilterLists.Services.List.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.List.MappingProfiles
{
    [UsedImplicitly]
    public class MaintainerAdditionalListsDtoMappingProfile : Profile
    {
        public MaintainerAdditionalListsDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, MaintainerAdditionalListsDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id));
    }
}