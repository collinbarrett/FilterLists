using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
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