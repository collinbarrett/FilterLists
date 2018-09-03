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
                .ForMember(d => d.Software,
                    o => o.MapFrom(l =>
                        l.Syntax.SoftwareSyntaxes.Select(ss => ss.Software.Name)))
                .ForMember(d => d.Tags, o => o.MapFrom(l => l.FilterListTags.Select(m => m.Tag)))
                .ForMember(d => d.UpdatedDate,
                    o => o.MapFrom(l =>
                        l.DiscontinuedDate ??
                        (l.Snapshots
                          .Count(s => s.WasSuccessful && s.Md5Checksum != null) >= 2
                            ? l.Snapshots
                               .Where(s => s.WasSuccessful && s.Md5Checksum != null)
                               .Select(s => s.CreatedDateUtc)
                               .OrderByDescending(c => c)
                               .FirstOrDefault()
                            : null)));
    }
}