using System;
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
                .ForMember(dto => dto.AddedDate, conf => conf.MapFrom(list => list.CreatedDateUtc))
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list => list.FilterListLanguages.Select(listLangs => listLangs.Language.Name)))
                .ForMember(dto => dto.Maintainers,
                    conf => conf.MapFrom(list =>
                        list.FilterListMaintainers.Select(listMaints => listMaints.Maintainer)))
                .ForMember(dto => dto.RuleCount,
                    conf => conf.MapFrom(list =>
                        list.Snapshots.Where(s => s.IsCompleted && s.HttpStatusCode == "200")
                            .SelectMany(sr => sr.AddedSnapshotRules)
                            .Count() - list.Snapshots.Where(s => s.IsCompleted && s.HttpStatusCode == "200")
                                           .SelectMany(sr => sr.RemovedSnapshotRules)
                                           .Count()))
                .ForMember(dto => dto.UpdatedDate,
                    conf => conf.MapFrom(list =>
                        list.Snapshots.Where(s =>
                                s.IsCompleted && s.HttpStatusCode == "200" &&
                                (s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0))
                            .OrderByDescending(s => s.CreatedDateUtc)
                            .Select(s => s.CreatedDateUtc)
                            .Cast<DateTime?>()
                            .FirstOrDefault()));
    }
}