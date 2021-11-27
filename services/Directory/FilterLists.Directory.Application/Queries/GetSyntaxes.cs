using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetSyntaxes
{
    public record Query : IRequest<List<SyntaxVm>>;

    internal class Handler : IRequestHandler<Query, List<SyntaxVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<SyntaxVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return _context.Syntaxes
                .OrderBy(s => s.Id)
                .ProjectTo<SyntaxVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class SyntaxVmProfile : Profile
    {
        public SyntaxVmProfile()
        {
            CreateMap<Syntax, SyntaxVm>()
                .ForMember(s => s.FilterListIds,
                    o => o.MapFrom(s =>
                        s.FilterListSyntaxes.OrderBy(fls => fls.FilterListId).Select(sls => sls.FilterListId)))
                .ForMember(s => s.SoftwareIds,
                    o => o.MapFrom(s =>
                        s.SoftwareSyntaxes.OrderBy(ss => ss.SoftwareId).Select(ss => ss.SoftwareId)));
        }
    }

    public record SyntaxVm
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        /// <example>3</example>
        public long Id { get; init; }

        /// <summary>
        /// The unique name.
        /// </summary>
        /// <example>Adblock Plus</example>
        public string Name { get; init; } = default!;

        /// <summary>
        /// The description.
        /// </summary>
        /// <example>null</example>
        public string? Description { get; init; }

        /// <summary>
        /// The URL of the home page.
        /// </summary>
        /// <example>https://adblockplus.org/filters</example>
        public Uri? Url { get; init; }

        /// <summary>
        /// The identifiers of the FilterLists implementing this Syntax.
        /// </summary>
        /// <example>[ 2, 6, 11 ]</example>
        public IEnumerable<long> FilterListIds { get; init; } = new HashSet<long>();

        /// <summary>
        /// The identifiers of the Software that supports this Syntax.
        /// </summary>
        /// <example>[ 1, 2, 3 ]</example>
        public IEnumerable<long> SoftwareIds { get; init; } = new HashSet<long>();
    }
}
