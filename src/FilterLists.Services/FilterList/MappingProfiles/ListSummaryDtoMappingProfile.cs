using System;
using System.Linq;
using AutoMapper;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.MappingProfiles
{
    [UsedImplicitly]
    public class ListSummaryDtoMappingProfile : Profile
    {
        private readonly Func<Data.Entities.Snapshot, bool> isDiffSnapshot =
            s => s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0;

        private readonly Func<Data.Entities.Snapshot, bool> isSuccessfulSnapshot =
            s => s.IsCompleted && s.HttpStatusCode == "200";

        public ListSummaryDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListSummaryDto>()
                .ForMember(d => d.AddedDate, c => c.MapFrom(l => l.CreatedDateUtc))
                .ForMember(d => d.Languages, c => c.MapFrom(l => l.FilterListLanguages.Select(la => la.Language)))
                .ForMember(d => d.UpdatedDate,
                    c => c.MapFrom(l =>
                        l.Snapshots.Where(isSuccessfulSnapshot)
                         .Where(isDiffSnapshot)
                         .OrderByDescending(s => s.CreatedDateUtc)
                         .Select(s => s.CreatedDateUtc)
                         .Cast<DateTime?>()
                         .FirstOrDefault()));
    }
}