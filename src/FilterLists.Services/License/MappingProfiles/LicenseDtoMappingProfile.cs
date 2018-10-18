using System.Linq;
using AutoMapper;
using FilterLists.Services.License.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.License.MappingProfiles
{
    [UsedImplicitly]
    public class LicenseDtoMappingProfile : Profile
    {
        public LicenseDtoMappingProfile() =>
            CreateMap<Data.Entities.License, LicenseDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        src.Id))
                .ForMember(dest => dest.FilterListIds,
                    opt => opt.MapFrom(src =>
                        src.FilterLists
                           .Select(l => l.Id)));
    }
}