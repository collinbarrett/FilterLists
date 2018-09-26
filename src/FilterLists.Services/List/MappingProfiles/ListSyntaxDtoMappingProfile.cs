using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.List.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.List.MappingProfiles
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