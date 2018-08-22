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
            CreateMap<Tag, ListTagDto>().ForMember(d => d.ColorHex, c => c.MapFrom(m => TagColors.Colors[(int)m.Id]));
    }
}