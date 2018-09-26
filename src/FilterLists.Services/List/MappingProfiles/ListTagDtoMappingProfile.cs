using AutoMapper;
using FilterLists.Services.List.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.List.MappingProfiles
{
    [UsedImplicitly]
    public class ListTagDtoMappingProfile : Profile
    {
        public ListTagDtoMappingProfile() =>
            CreateMap<Data.Entities.Tag, ListTagDto>()
                .ForMember(dest => dest.ColorHex,
                    opt => opt.MapFrom(src =>
                        TagColors.Colors[(int)src.Id]));
    }
}