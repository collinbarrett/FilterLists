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
                .ForMember(d => d.AddedDate, c => c.MapFrom(l => l.CreatedDateUtc))
                .ForMember(d => d.Languages, c => c.MapFrom(l => l.FilterListLanguages.Select(la => la.Language.Name)))
                .ForMember(d => d.Maintainers, c => c.MapFrom(l => l.FilterListMaintainers.Select(m => m.Maintainer)))
                .ForMember(d => d.RuleCount,
                    c => c.MapFrom(l =>
                        l.Snapshots.Where(s => s.IsCompleted && s.HttpStatusCode == "200")
                         .SelectMany(sr => sr.AddedSnapshotRules)
                         .Count() -
                        l.Snapshots.Where(s => s.IsCompleted && s.HttpStatusCode == "200")
                         .SelectMany(sr => sr.RemovedSnapshotRules)
                         .Count()))
                .ForMember(d => d.UpdatedDate,
                    c => c.MapFrom(l =>
                        l.Snapshots.Where(s => s.IsCompleted && s.HttpStatusCode == "200")
                         .Where(s => s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0)
                         .OrderByDescending(s => s.CreatedDateUtc)
                         .Select(s => s.CreatedDateUtc)
                         .FirstOrDefault()));
    }
}