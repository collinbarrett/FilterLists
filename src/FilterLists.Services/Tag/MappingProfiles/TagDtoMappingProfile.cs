using System.Linq;
using AutoMapper;
using FilterLists.Services.Tag.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.Tag.MappingProfiles
{
    [UsedImplicitly]
    public class TagDtoMappingProfile : Profile
    {
        public TagDtoMappingProfile() =>
            CreateMap<Data.Entities.Tag, TagDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        src.Id))
                .ForMember(dest => dest.FilterListIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListTags
                           .Select(ft => ft.FilterListId)));
    }
}