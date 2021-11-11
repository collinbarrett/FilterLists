using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetLicenses
{
    public class Query : IRequest<IEnumerable<LicenseVm>>
    {
    }

    internal class Handler : IRequestHandler<Query, IEnumerable<LicenseVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LicenseVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return await _context.Licenses
                .OrderBy(l => l.Id)
                .ProjectTo<LicenseVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class LicenseVmProfile : Profile
    {
        public LicenseVmProfile()
        {
            CreateMap<License, LicenseVm>()
                .ForMember(l => l.FilterListIds,
                    o => o.MapFrom(l =>
                        l.FilterLists.Select(fl => fl.Id).OrderBy(flid => flid).AsEnumerable()));
        }
    }

    public class LicenseVm
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public Uri? Url { get; init; }
        public bool PermitsModification { get; init; }
        public bool PermitsDistribution { get; init; }
        public bool PermitsCommercialUse { get; init; }
        public IEnumerable<int>? FilterListIds { get; init; }
    }
}
