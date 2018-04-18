using System.Linq;
using AutoMapper;
using FilterLists.Data.Entities;

namespace FilterLists.Services.FilterList
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Data.Entities.FilterList, ListSummaryDto>()
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list =>
                        list.FilterListLanguages.Select(listLangs => listLangs.Language)));

            CreateMap<Data.Entities.FilterList, ListDetailsDto>()
                .ForMember(dto => dto.Languages,
                    conf => conf.MapFrom(list =>
                        list.FilterListLanguages.Select(listLangs => listLangs.Language.Name)))
                .ForMember(dto => dto.Maintainers,
                    conf => conf.MapFrom(list =>
                        list.FilterListMaintainers.Select(listMaints => listMaints.Maintainer)));

            CreateMap<Maintainer, ListMaintainerDto>()
                .ForMember(dto => dto.AdditionalLists,
                    conf => conf.MapFrom(maint =>
                        maint.FilterListMaintainers.Select(listMaints => listMaints.FilterList)));

            CreateMap<Syntax, ListSyntaxDto>()
                .ForMember(dto => dto.SupportedSoftware,
                    conf => conf.MapFrom(syntax =>
                        syntax.SoftwareSyntaxes.Select(softSyn => softSyn.Software)));
        }
    }
}