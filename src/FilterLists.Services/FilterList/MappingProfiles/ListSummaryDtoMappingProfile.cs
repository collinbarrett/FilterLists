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
        public ListSummaryDtoMappingProfile() =>
            CreateMap<Data.Entities.FilterList, ListSummaryDto>()
                .ForMember(dto => dto.AddedDate, conf => conf.MapFrom(list => list.CreatedDateUtc))
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list => list.FilterListLanguages.Select(listLangs => listLangs.Language)))
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