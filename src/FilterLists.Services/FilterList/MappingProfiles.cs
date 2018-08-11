using System;
using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;
using FilterLists.Services.FilterList.Models;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateListSummaryDtoMap();
            CreateListDetailsDtoMap();
            CreateListMaintainerDtoMap();
            CreateListSyntaxDtoMap();
        }

        private void CreateListSummaryDtoMap() =>
            CreateMap<Data.Entities.FilterList, ListSummaryDto>()
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list => list.FilterListLanguages.Select(listLangs => listLangs.Language)))
                .ForMember(dto => dto.AddedDate, conf => conf.MapFrom(list => list.CreatedDateUtc))
                .ForMember(dto => dto.UpdatedDate,
                    conf => conf.MapFrom(list =>
                        list.Snapshots.Where(s =>
                                s.IsCompleted && s.HttpStatusCode == "200" &&
                                (s.AddedSnapshotRules.Count > 0 || s.RemovedSnapshotRules.Count > 0))
                            .OrderByDescending(s => s.CreatedDateUtc)
                            .Select(s => s.CreatedDateUtc)
                            .Cast<DateTime?>()
                            .FirstOrDefault()));

        private void CreateListDetailsDtoMap() =>
            CreateMap<Data.Entities.FilterList, ListDetailsDto>()
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list => list.FilterListLanguages.Select(listLangs => listLangs.Language.Name)))
                .ForMember(dto => dto.Maintainers,
                    conf => conf.MapFrom(list =>
                        list.FilterListMaintainers.Select(listMaints => listMaints.Maintainer)))
                .ForMember(dto => dto.AddedDate, conf => conf.MapFrom(list => list.CreatedDateUtc));

        private void CreateListMaintainerDtoMap() =>
            CreateMap<Maintainer, ListMaintainerDto>()
                .ForMember(dto => dto.AdditionalLists,
                    conf => conf.MapFrom(maint =>
                        maint.FilterListMaintainers.Select(listMaints => listMaints.FilterList)));

        private void CreateListSyntaxDtoMap() =>
            CreateMap<Syntax, ListSyntaxDto>()
                .ForMember(dto => dto.SupportedSoftware,
                    conf => conf.MapFrom(syntax => syntax.SoftwareSyntaxes.Select(softSyn => softSyn.Software)));
    }
}