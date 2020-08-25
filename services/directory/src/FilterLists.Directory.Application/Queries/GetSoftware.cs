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
    public static class GetSoftware
    {
        public class Query : IRequest<IEnumerable<SoftwareViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<SoftwareViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<SoftwareViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Software
                    .ProjectTo<SoftwareViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class SoftwareViewModelProfile : Profile
        {
            public SoftwareViewModelProfile()
            {
                CreateMap<Software, SoftwareViewModel>();
            }
        }

        public class SoftwareViewModel
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public string? Description { get; private set; }
            public Uri? HomeUrl { get; private set; }
            public Uri? DownloadUrl { get; private set; }
            public bool SupportsAbpUrlScheme { get; private set; }
            public IEnumerable<int>? SyntaxIds { get; private set; }
        }
    }
}