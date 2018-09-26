using System.Linq;
using AutoMapper;
using FilterLists.Services.List.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.List.MappingProfiles
{
    [UsedImplicitly]
    public class ListDetailsDtoMappingProfile : Profile
    {
        public ListDetailsDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListDetails>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id))
                .ForMember(dest => dest.Languages,
                    opt => opt.MapFrom(src =>
                        src.FilterListLanguages.Select(la => la.Language.Name)))
                .ForMember(dest => dest.Maintainers,
                    opt => opt.MapFrom(src =>
                        src.FilterListMaintainers.Select(m => m.Maintainer)))
                .ForMember(dest => dest.Tags,
                    opt => opt.MapFrom(src =>
                        src.FilterListTags.Select(m => m.Tag)))
                .ForMember(dest => dest.RuleCount,
                    opt => opt.MapFrom(src =>
                        src.Snapshots
                           .Count(s => s.WasSuccessful) > 0
                            ? src.Snapshots
                                 .Where(s => s.WasSuccessful)
                                 .OrderByDescending(s => s.CreatedDateUtc)
                                 .FirstOrDefault()
                                 .SnapshotRules
                                 .Count
                            : 0))
                .ForMember(dest => dest.UpdatedDate,
                    opt => opt.MapFrom(src =>
                        src.DiscontinuedDate ??
                        (src.Snapshots
                            .Count(s => s.WasSuccessful && s.Md5Checksum != null) >= 2
                            ? src.Snapshots
                                 .Where(s => s.WasSuccessful && s.Md5Checksum != null)
                                 .Select(s => s.CreatedDateUtc)
                                 .OrderByDescending(c => c)
                                 .FirstOrDefault()
                            : null)))
                .ForMember(dest => dest.ViewUrl,
                    opt => opt.MapFrom(src =>
                        src.Snapshots
                           .Where(s => s.WasSuccessful)
                           .OrderByDescending(s => s.CreatedDateUtc)
                           .FirstOrDefault()
                           .WaybackUrl ?? src.ViewUrl));
    }
}