using AutoMapper;
using FilterLists.Services.Language.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class LanguageDtoMappingProfile : Profile
    {
        public LanguageDtoMappingProfile() =>
            CreateMap<Data.Entities.Language, LanguageDto>()
                .ForMember(d => d.Id, o => o.MapFrom(l => (int)l.Id));
    }
}