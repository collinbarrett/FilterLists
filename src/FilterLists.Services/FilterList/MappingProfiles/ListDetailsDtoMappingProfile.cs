using System.Linq;
using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListDetailsDtoMappingProfile : Profile
    {
        public ListDetailsDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListDetailsDto>()
                .ForMember(d => d.Languages, o => o.MapFrom(l => l.FilterListLanguages.Select(la => la.Language.Name)))
                .ForMember(d => d.Maintainers, o => o.MapFrom(l => l.FilterListMaintainers.Select(m => m.Maintainer)))
                .ForMember(d => d.Tags, o => o.MapFrom(l => l.FilterListTags.Select(m => m.Tag)))
                .ForMember(d => d.RuleCount, o => o.MapFrom(l =>
                    l.Snapshots
                     .Count(s => s.WasSuccessful) > 0
                        ? l.Snapshots
                           .Where(s => s.WasSuccessful)
                           .OrderByDescending(s => s.CreatedDateUtc)
                           .FirstOrDefault()
                           .SnapshotRules
                           .Count
                        : 0))
                .ForMember(d => d.UpdatedDate, o => o.MapFrom(l => l.ModifiedDateUtc))
                .ForMember(d => d.ViewUrl,
                    o => o.MapFrom(l =>
                        l.Snapshots
                         .Where(s => s.WasSuccessful)
                         .OrderByDescending(s => s.CreatedDateUtc)
                         .FirstOrDefault()
                         .WaybackUrl ?? l.ViewUrl));
    }
}