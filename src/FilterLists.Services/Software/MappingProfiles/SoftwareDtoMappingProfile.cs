using System.Linq;
using AutoMapper;
using FilterLists.Services.Software.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class SoftwareDtoMappingProfile : Profile
    {
        public SoftwareDtoMappingProfile() =>
            CreateMap<Data.Entities.Software, SoftwareDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id))
                .ForMember(dest => dest.SyntaxIds,
                    opt => opt.MapFrom(src =>
                        src.SoftwareSyntaxes.Select(ss => (int)ss.SyntaxId)));
    }
}