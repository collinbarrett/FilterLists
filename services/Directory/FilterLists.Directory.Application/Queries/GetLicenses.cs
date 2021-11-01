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
    public static class GetLicenses
    {
        public class Query : IRequest<IEnumerable<LicenseVm>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<LicenseVm>>
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

        public class LicenseVmProfile : Profile
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
            public int Id { get; }
            public string Name { get; } = null!;
            public Uri? Url { get; }
            public bool PermitsModification { get; }
            public bool PermitsDistribution { get; }
            public bool PermitsCommercialUse { get; }
            public IEnumerable<int>? FilterListIds { get; }
        }
    }
}
