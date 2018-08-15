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
                .ForMember(d => d.Languages, c => c.MapFrom(l => l.FilterListLanguages.Select(la => la.Language)))
                .ForMember(d => d.UpdatedDate,
                    c => c.MapFrom(l =>
                        l.Snapshots.Where(s => s.IsCompleted && s.HttpStatusCode == "200")
                         .Where(s => s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0)
                         .OrderByDescending(s => s.CreatedDateUtc)
                         .Select(s => s.CreatedDateUtc)
                         .FirstOrDefault()));
    }
}