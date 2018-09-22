using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListTagDtoMappingProfile : Profile
    {
        public ListTagDtoMappingProfile() =>
            CreateMap<Tag, ListTagDto>()
                .ForMember(dest => dest.ColorHex,
                    opt => opt.MapFrom(src =>
                        TagColors.Colors[(int)src.Id]));
    }
}