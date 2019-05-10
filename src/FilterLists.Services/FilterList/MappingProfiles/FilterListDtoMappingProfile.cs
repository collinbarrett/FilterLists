using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class FilterListDtoMappingProfile : Profile
    {
        public FilterListDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, FilterListDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        src.Id))
                .ForMember(dest => dest.LanguageIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListLanguages
                           .Select(ll => ll.LanguageId)))
                .ForMember(dest => dest.LicenseId,
                    opt => opt.MapFrom(src =>
                        src.LicenseId))
                .ForMember(dest => dest.MaintainerIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListMaintainers
                           .Select(ll => ll.MaintainerId)))
                //.ForMember(dest => dest.RuleCount,
                //    opt => opt.MapFrom(src =>
                //        src.Snapshots
                //           .Where(s => s.WasSuccessful)
                //           .Select(s => (int?)s.SnapshotRules.Count)
                //           .FirstOrDefault()))
                .ForMember(dest => dest.SyntaxId,
                    opt => opt.MapFrom(src =>
                        src.SyntaxId))
                .ForMember(dest => dest.TagIds,
                    opt => opt.MapFrom(src =>
                        src.FilterListTags
                           .Select(lt => lt.TagId)))
                .ForMember(dest => dest.ViewUrlMirrors,
                    opt => opt.MapFrom(src =>
                        src.ViewUrlMirror1 != null
                            ? src.ViewUrlMirror2 != null
                                ? new List<string> {src.ViewUrlMirror1, src.ViewUrlMirror2}
                                : new List<string> {src.ViewUrlMirror1}
                            : null));
    }
}