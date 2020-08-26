using System;
using System.Collections.Generic;
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
    public static class GetLists
    {
        public class Query : IRequest<IEnumerable<ListViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<ListViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<ListViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.FilterLists
                    .ProjectTo<ListViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class ListViewModelProfile : Profile
        {
            public ListViewModelProfile()
            {
                CreateMap<FilterList, ListViewModel>();
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
            //public IEnumerable<SegmentViewUrl>? SegmentViewUrls { get; private set; }
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
    }
}