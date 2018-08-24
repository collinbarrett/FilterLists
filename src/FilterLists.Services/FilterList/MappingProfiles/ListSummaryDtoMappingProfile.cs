using System.Linq;
using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListSummaryDtoMappingProfile : Profile
    {
        public ListSummaryDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListSummaryDto>()
                .ForMember(d => d.Languages, o => o.MapFrom(l => l.FilterListLanguages.Select(la => la.Language)))
                .ForMember(d => d.Tags, o => o.MapFrom(l => l.FilterListTags.Select(m => m.Tag)))
                .ForMember(d => d.UpdatedDate, o => o.MapFrom(l => l.ModifiedDateUtc));
    }
}