using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListIndexRecordMappingProfile : Profile
    {
        public ListIndexRecordMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListIndexRecord>()
                .ForMember(r => r.Id,
                    o => o.MapFrom(l =>
                        (int)l.Id))
                .ForMember(r => r.LanguageIds,
                    o => o.MapFrom(l =>
                        l.FilterListLanguages.Select(ll => (int)ll.LanguageId)))
                .ForMember(r => r.MaintainerIds,
                    o => o.MapFrom(l =>
                        l.FilterListMaintainers.Select(ll => (int)ll.MaintainerId)))
                .ForMember(r => r.RuleCount,
                    o => o.MapFrom(l =>
                        l.Snapshots
                         .Where(s => s.WasSuccessful)
                         .Select(s => (int?)s.SnapshotRules.Count)
                         .FirstOrDefault()))
                .ForMember(r => r.SyntaxId,
                    o => o.MapFrom(l =>
                        (int)l.SyntaxId))
                .ForMember(r => r.TagIds,
                    o => o.MapFrom(l =>
                        l.FilterListTags.Select(lt => (int)lt.TagId)))
                .ForMember(r => r.UpdatedDate,
                    o => o.MapFrom(l =>
                        l.Snapshots
                         .Count(s => s.WasSuccessful && s.WasUpdated) >= 2
                            ? l.Snapshots
                               .Where(s => s.WasSuccessful && s.WasUpdated)
                               .Select(s => s.CreatedDateUtc)
                               .OrderByDescending(c => c)
                               .FirstOrDefault()
                            : null))
                .ForMember(r => r.ViewUrlMirrors,
                    o => o.MapFrom(l =>
                        l.ViewUrlMirror1 != null
                            ? l.ViewUrlMirror2 != null
                                ? new List<string> {l.ViewUrlMirror1, l.ViewUrlMirror2}
                                : new List<string> {l.ViewUrlMirror1}
                            : null));
    }
}