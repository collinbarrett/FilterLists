using System.Linq;
using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListSummaryDtoMappingProfile : Profile
    {
        //TODO: fix UpdatedDate to look at most recent snapshot with changes
        public ListSummaryDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListSummaryDto>()
                .ForMember(d => d.Languages, c => c.MapFrom(l => l.FilterListLanguages.Select(la => la.Language)))
                .ForMember(d => d.Tags, c => c.MapFrom(l => l.FilterListTags.Select(m => m.Tag)))
                .ForMember(d => d.UpdatedDate,
                    c => c.MapFrom(l =>
                        l.Snapshots.Where(s => s.WasSuccessful)
                         .OrderByDescending(s => s.CreatedDateUtc)
                         .FirstOrDefault()
                         .CreatedDateUtc));
    }
}