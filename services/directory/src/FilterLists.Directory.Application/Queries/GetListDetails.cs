using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries
{
    public static class GetListDetails
    {
        public class Query : IRequest<ListViewModel>
        {
            public Query(int id)
            {
                Id = id;
            }

            public int Id { get; }
        }

        public class Handler : IRequestHandler<Query, ListViewModel>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ListViewModel> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.FilterLists
                    .ProjectTo<ListViewModel>(_mapper.ConfigurationProvider)
                    .SingleOrDefaultAsync(fl => fl.Id == request.Id, cancellationToken);
            }
        }

        public class ListViewModelProfile : Profile
        {
            public ListViewModelProfile()
            {
                CreateMap<FilterList, ListViewModel>()
                    .ForMember(fl => fl.SyntaxIds,
                        o => o.MapFrom(fl =>
                            fl.FilterListSyntaxes.Select(fls => fls.SyntaxId).OrderBy(sid => sid)))
                    .ForMember(fl => fl.LanguageIso6391s,
                        o => o.MapFrom(fl =>
                            fl.FilterListLanguages.Select(fls => fls.Iso6391).OrderBy(i => i)))
                    .ForMember(fl => fl.TagIds,
                        o => o.MapFrom(fl =>
                            fl.FilterListTags.Select(flt => flt.TagId).OrderBy(tid => tid)))
                    .ForMember(fl => fl.ViewUrls,
                        o => o.MapFrom(fl =>
                            fl.ViewUrls.OrderBy(u => u.SegmentNumber).ThenBy(u => u.Primariness)))
                    .ForMember(fl => fl.MaintainerIds,
                        o => o.MapFrom(fl =>
                            fl.FilterListMaintainers.Select(flm => flm.MaintainerId).OrderBy(mid => mid)))
                    .ForMember(fl => fl.UpstreamFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.UpstreamFilterLists.Select(ufl => ufl.UpstreamFilterListId).OrderBy(flid => flid)))
                    .ForMember(fl => fl.ForkFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.ForkFilterLists.Select(ffl => ffl.ForkFilterListId).OrderBy(flid => flid)))
                    .ForMember(fl => fl.IncludedInFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.IncludedInFilterLists.Select(iifl => iifl.IncludedInFilterListId).OrderBy(flid => flid)))
                    .ForMember(fl => fl.IncludesFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.IncludesFilterLists.Select(ifl => ifl.IncludesFilterListId).OrderBy(flid => flid)))
                    .ForMember(fl => fl.DependencyFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.DependencyFilterLists.Select(dfl => dfl.DependencyFilterListId).OrderBy(flid => flid)))
                    .ForMember(fl => fl.DependentFilterListIds,
                        o => o.MapFrom(fl =>
                            fl.DependentFilterLists.Select(dfl => dfl.DependentFilterListId).OrderBy(flid => flid)));
            }
        }

        public class ViewUrlViewModelProfile : Profile
        {
            public ViewUrlViewModelProfile()
            {
                CreateMap<FilterListViewUrl, ViewUrlViewModel>();
            }
        }

        public class ListViewModel
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public string? Description { get; private set; }
            public int? LicenseId { get; private set; }
            public IEnumerable<int>? SyntaxIds { get; private set; }
            public IEnumerable<string>? LanguageIso6391s { get; private set; }
            public IEnumerable<int>? TagIds { get; private set; }
            public IEnumerable<ViewUrlViewModel>? ViewUrls { get; private set; }
            public Uri? HomeUrl { get; private set; }
            public Uri? OnionUrl { get; private set; }
            public Uri? PolicyUrl { get; private set; }
            public Uri? SubmissionUrl { get; private set; }
            public Uri? IssuesUrl { get; private set; }
            public Uri? ForumUrl { get; private set; }
            public Uri? ChatUrl { get; private set; }
            public string? EmailAddress { get; private set; }
            public Uri? DonateUrl { get; private set; }
            public IEnumerable<int>? MaintainerIds { get; private set; }
            public IEnumerable<int>? UpstreamFilterListIds { get; private set; }
            public IEnumerable<int>? ForkFilterListIds { get; private set; }
            public IEnumerable<int>? IncludedInFilterListIds { get; private set; }
            public IEnumerable<int>? IncludesFilterListIds { get; private set; }
            public IEnumerable<int>? DependencyFilterListIds { get; private set; }
            public IEnumerable<int>? DependentFilterListIds { get; private set; }
        }

        public class ViewUrlViewModel
        {
            public short SegmentNumber { get; private set; }
            public short Primariness { get; private set; }
            public Uri Url { get; private set; } = null!;
        }
    }
}