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

        internal class Handler : IRequestHandler<Query, IEnumerable<SoftwareVm>>
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

        internal class SoftwareVmProfile : Profile
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
