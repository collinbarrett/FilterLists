using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListSyntaxDtoMappingProfile : Profile
    {
        public ListSyntaxDtoMappingProfile() =>
            CreateMap<Syntax, ListSyntaxDto>()
                .ForMember(dest => dest.SupportedSoftware,
                    opt => opt.MapFrom(src =>
                        src.SoftwareSyntaxes
                           .Select(ss => ss.Software)
                           .OrderBy(s => s.Name)));
    }
}