using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
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