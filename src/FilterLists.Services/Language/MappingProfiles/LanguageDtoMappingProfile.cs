using System.Linq;
using AutoMapper;
using FilterLists.Services.Language.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.Language.MappingProfiles
{
    [UsedImplicitly]
    public class LanguageDtoMappingProfile : Profile
    {
        public LanguageDtoMappingProfile() =>
            CreateMap<Data.Entities.Language, LanguageDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        src.Id))
                .ForMember(dest => dest.FilterListIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListLanguages
                           .Select(fl => fl.FilterListId)));
    }
}