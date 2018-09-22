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
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id))
                .ForMember(dest => dest.LanguageIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListLanguages.Select(ll => (int)ll.LanguageId)))
                .ForMember(dest => dest.MaintainerIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListMaintainers.Select(ll => (int)ll.MaintainerId)))
                .ForMember(dest => dest.RuleCount,
                    opt => opt.MapFrom(src =>
                        src.Snapshots
                           .Where(s => s.WasSuccessful)
                           .Select(s => (int?)s.SnapshotRules.Count)
                           .FirstOrDefault()))
                .ForMember(dest => dest.SyntaxId,
                    opt => opt.MapFrom(src =>
                        (int)src.SyntaxId))
                .ForMember(dest => dest.TagIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListTags.Select(lt => (int)lt.TagId)))
                .ForMember(dest => dest.UpdatedDate,
                    opt => opt.MapFrom(src =>
                        src.Snapshots
                           .Count(s => s.WasSuccessful && s.WasUpdated) >= 2
                            ? src.Snapshots
                                 .Where(s => s.WasSuccessful && s.WasUpdated)
                                 .Select(s => s.CreatedDateUtc)
                                 .OrderByDescending(c => c)
                                 .FirstOrDefault()
                            : null))
                .ForMember(dest => dest.ViewUrlMirrors,
                    opt => opt.MapFrom(src =>
                        src.ViewUrlMirror1 != null
                            ? src.ViewUrlMirror2 != null
                                ? new List<string> {src.ViewUrlMirror1, src.ViewUrlMirror2}
                                : new List<string> {src.ViewUrlMirror1}
                            : null));
    }
}