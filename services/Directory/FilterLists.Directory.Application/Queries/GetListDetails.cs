using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Api.Contracts.Models;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries
{
    public static class GetListDetails
    {
        public class Query : IRequest<ListDetailsVm?>
        {
            public Query(int id)
            {
                Id = id;
            }

            public int Id { get; }
        }

        internal class Handler : IRequestHandler<Query, ListDetailsVm?>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ListDetailsVm?> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.FilterLists
                    .ProjectTo<ListDetailsVm>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(fl => fl.Id == request.Id, cancellationToken);
            }
        }

        internal class ListDetailsVmProfile : Profile
        {
            public ListDetailsVmProfile()
            {
                CreateMap<FilterList, ListDetailsVm>()
                    .ForMember(fl => fl.SyntaxIds,
                        o => o.MapFrom(fl =>
                            fl.FilterListSyntaxes.Select(fls => fls.SyntaxId).OrderBy(sid => sid).AsEnumerable()))
                    .ForMember(fl => fl.Iso6391s,
                        o => o.MapFrom(fl =>
                            fl.FilterListLanguages.Select(fls => fls.Iso6391).OrderBy(i => i).AsEnumerable()))
                    .ForMember(fl => fl.TagIds,
                        o => o.MapFrom(fl =>
                            fl.FilterListTags.Select(flt => flt.TagId).OrderBy(tid => tid).AsEnumerable()))
                    .ForMember(fl => fl.ViewUrls,
                        o => o.MapFrom(fl =>
                            fl.ViewUrls.OrderBy(u => u.SegmentNumber).ThenBy(u => u.Primariness).AsEnumerable()))
                    .ForMember(fl => fl.MaintainerIds,
                        o => o.MapFrom(fl =>
                            fl.FilterListMaintainers.Select(flm => flm.MaintainerId).OrderBy(mid => mid)
                                .AsEnumerable()))
                    .ForMember(fl => fl.UpstreamFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.UpstreamFilterLists.Select(ufl => ufl.UpstreamFilterListId).OrderBy(flid => flid)
                                .AsEnumerable()))
                    .ForMember(fl => fl.ForkFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.ForkFilterLists.Select(ffl => ffl.ForkFilterListId).OrderBy(flid => flid)
                                .AsEnumerable()))
                    .ForMember(fl => fl.IncludedInFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.IncludedInFilterLists.Select(iifl => iifl.IncludedInFilterListId).OrderBy(flid => flid)
                                .AsEnumerable()))
                    .ForMember(fl => fl.IncludesFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.IncludesFilterLists.Select(ifl => ifl.IncludesFilterListId).OrderBy(flid => flid)
                                .AsEnumerable()))
                    .ForMember(fl => fl.DependencyFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.DependencyFilterLists.Select(dfl => dfl.DependencyFilterListId).OrderBy(flid => flid)
                                .AsEnumerable()))
                    .ForMember(fl => fl.DependentFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.DependentFilterLists.Select(dfl => dfl.DependentFilterListId).OrderBy(flid => flid)
                                .AsEnumerable()));

                CreateMap<FilterListViewUrl, ListDetailsVm.ViewUrlVm>();
            }
        }
    }
}
