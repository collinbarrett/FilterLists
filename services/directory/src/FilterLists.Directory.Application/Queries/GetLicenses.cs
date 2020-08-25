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
    public static class GetLicenses
    {
        public class Query : IRequest<IEnumerable<LicenseViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<LicenseViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<LicenseViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Maintainers
                    .ProjectTo<LicenseViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class LicenseViewModelProfile : Profile
        {
            public LicenseViewModelProfile()
            {
                CreateMap<License, LicenseViewModel>();
            }
        }

        public class LicenseViewModel
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public string? GitHubKey { get; private set; }
            public Uri? Url { get; private set; }
            public IEnumerable<int>? FilterListIds { get; private set; }
        }
    }
}