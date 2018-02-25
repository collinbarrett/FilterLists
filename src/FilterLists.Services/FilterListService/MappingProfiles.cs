using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;

namespace FilterLists.Services.FilterListService
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<FilterList, FilterListDetailsDto>()
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list =>
                        list.FilterListLanguages.Select(listLangs => listLangs.Language.Name)))
                .ForMember(dto => dto.Maintainers,
                    conf => conf.MapFrom(list =>
                        list.FilterListMaintainers.Select(listMaints => listMaints.Maintainer)));

            //TODO: improve performance (https://stackoverflow.com/q/48897083/2343739)
            CreateMap<FilterList, FilterListSummaryDto>()
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list =>
                        list.FilterListLanguages.Select(listLangs => listLangs.Language.Name)));
        }
    }
}