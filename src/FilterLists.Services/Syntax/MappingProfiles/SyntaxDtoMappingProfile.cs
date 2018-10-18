using System.Linq;
using AutoMapper;
using FilterLists.Services.Syntax.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.Syntax.MappingProfiles
{
    [UsedImplicitly]
    public class SyntaxDtoMappingProfile : Profile
    {
        public SyntaxDtoMappingProfile() =>
            CreateMap<Data.Entities.Syntax, SyntaxDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        src.Id))
                .ForMember(dest => dest.FilterListIds,
                    opt => opt.MapFrom(src =>
                        src.FilterLists
                           .Select(l => l.Id)))
                .ForMember(dest => dest.SoftwareIds,
                    opt => opt.MapFrom(src =>
                        src.SoftwareSyntaxes
                           .Select(ss => ss.SoftwareId)));
    }
}