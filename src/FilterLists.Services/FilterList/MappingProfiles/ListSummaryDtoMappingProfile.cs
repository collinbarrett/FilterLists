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
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src =>
                        (int)src.Id))
                .ForMember(dest => dest.Languages,
                    opt => opt.MapFrom(src =>
                        src.FilterListLanguages.Select(la => la.Language)))
                .ForMember(dest => dest.SoftwareIds,
                    opt => opt.MapFrom(src =>
                        src.Syntax
                           .SoftwareSyntaxes
                           .Select(ss => ss.Software)
                           .OrderBy(s => s.Name)
                           .Select(s => (int)s.Id)))
                .ForMember(dest => dest.Tags,
                    opt => opt.MapFrom(src =>
                        src.FilterListTags.Select(m => m.Tag)))
                .ForMember(dest => dest.UpdatedDate,
                    opt => opt.MapFrom(src =>
                        src.DiscontinuedDate ??
                        (src.Snapshots.Count(s => s.WasSuccessful && s.Md5Checksum != null) >= 2
                            ? src.Snapshots
                                 .Where(s => s.WasSuccessful && s.Md5Checksum != null)
                                 .Select(s => s.CreatedDateUtc)
                                 .OrderByDescending(c => c)
                                 .FirstOrDefault()
                            : null)));
    }
}