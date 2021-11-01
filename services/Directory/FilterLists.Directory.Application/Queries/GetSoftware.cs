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
    public static class GetSoftware
    {
        public class Query : IRequest<IEnumerable<SoftwareVm>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<SoftwareVm>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<SoftwareVm>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Software
                    .OrderBy(s => s.Id)
                    .ProjectTo<SoftwareVm>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class SoftwareVmProfile : Profile
        {
            public SoftwareVmProfile()
            {
                CreateMap<Software, SoftwareVm>()
                    .ForMember(s => s.SyntaxIds,
                        o => o.MapFrom(s =>
                            s.SoftwareSyntaxes.Select(ss => ss.SyntaxId).OrderBy(sid => sid).AsEnumerable()));
            }
        }

        public class SoftwareVm
        {
            public int Id { get; }
            public string Name { get; } = null!;
            public string? Description { get; }
            public Uri? HomeUrl { get; }
            public Uri? DownloadUrl { get; }
            public bool SupportsAbpUrlScheme { get; }
            public IEnumerable<int>? SyntaxIds { get; }
        }
    }
}
