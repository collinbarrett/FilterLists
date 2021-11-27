using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLicenses
{
    public record Query : IRequest<List<LicenseVm>>;

    internal class Handler : IRequestHandler<Query, List<LicenseVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<LicenseVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return _context.Licenses
                .OrderBy(l => l.Id)
                .ProjectTo<LicenseVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class LicenseVmProfile : Profile
    {
        public LicenseVmProfile()
        {
            CreateMap<License, LicenseVm>().ForMember(l => l.FilterListIds,
                o => o.MapFrom(l => l.FilterLists.OrderBy(fl => fl.Id).Select(fl => fl.Id)));
        }
    }

    public record LicenseVm
    {
        /// <summary>
        ///     The identifier.
        /// </summary>
        /// <example>5</example>
        public long Id { get; private init; }

        /// <summary>
        ///     The unique name.
        /// </summary>
        /// <example>All Rights Reserved</example>
        public string Name { get; private init; } = default!;

        /// <summary>
        ///     The URL of the home page.
        /// </summary>
        /// <example>https://en.wikipedia.org/wiki/All_rights_reserved</example>
        public Uri? Url { get; private init; }

        /// <summary>
        ///     If the License permits modification.
        /// </summary>
        /// <example>false</example>
        public bool PermitsModification { get; private init; }

        /// <summary>
        ///     If the License permits distribution.
        /// </summary>
        /// <example>false</example>
        public bool PermitsDistribution { get; private init; }

        /// <summary>
        ///     If the License permits commercial use.
        /// </summary>
        /// <example>false</example>
        public bool PermitsCommercialUse { get; private init; }

        /// <summary>
        ///     The identifiers of the FilterLists released under this License.
        /// </summary>
        /// <example>[ 6, 31 ]</example>
        public IEnumerable<long> FilterListIds { get; private init; } = new HashSet<long>();
    }
}
