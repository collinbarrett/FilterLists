using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetSoftware
{
    public record Query : IRequest<List<SoftwareVm>>;

    internal class Handler : IRequestHandler<Query, List<SoftwareVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<SoftwareVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return _context.Software
                .OrderBy(s => s.Id)
                .ProjectTo<SoftwareVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class SoftwareVmProfile : Profile
    {
        public SoftwareVmProfile()
        {
            CreateMap<Software, SoftwareVm>()
                .ForMember(s => s.SyntaxIds,
                    o => o.MapFrom(s => s.SoftwareSyntaxes.OrderBy(ss => ss.SyntaxId).Select(ss => ss.SyntaxId)));
        }
    }

    public record SoftwareVm
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        /// <example>2</example>
        public long Id { get; init; }

        /// <summary>
        /// The unique name.
        /// </summary>
        /// <example>Adblock Plus</example>
        public string Name { get; init; } = default!;

        /// <summary>
        /// The description.
        /// </summary>
        /// <example>Adblock Plus is a free extension that allows you to customize your web experience. You can block annoying ads, disable tracking and lots more. It’s available for all major desktop browsers and for your mobile devices.</example>
        public string? Description { get; init; }

        /// <summary>
        /// The URL of the home page.
        /// </summary>
        /// <example>https://adblockplus.org/</example>
        public Uri? HomeUrl { get; init; }

        /// <summary>
        /// The URL of the Software download.
        /// </summary>
        /// <example>https://adblockplus.org/</example>
        public Uri? DownloadUrl { get; init; }

        /// <summary>
        /// If the Software supports the abp: URL scheme to click-to-subscribe to a FilterList.
        /// </summary>
        /// <example>true</example>
        public bool SupportsAbpUrlScheme { get; init; }

        /// <summary>
        /// The identifiers of the Syntaxes that this Software supports.
        /// </summary>
        /// <example>[ 3, 28, 38, 48 ]</example>
        public IEnumerable<long> SyntaxIds { get; init; } = new HashSet<long>();
    }
}
