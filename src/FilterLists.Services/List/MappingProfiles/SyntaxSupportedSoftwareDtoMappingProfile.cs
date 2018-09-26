using AutoMapper;
using FilterLists.Services.List.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.List.MappingProfiles
{
    [UsedImplicitly]
    public class SyntaxSupportedSoftwareDtoMappingProfile : Profile
    {
        public SyntaxSupportedSoftwareDtoMappingProfile() =>
            CreateMap<Data.Entities.Software, SyntaxSupportedSoftwareDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id));
    }
}