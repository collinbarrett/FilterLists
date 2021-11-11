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
            public int Id { get; init; }
            public string Name { get; init; } = null!;
            public string? Description { get; init; }
            public Uri? HomeUrl { get; init; }
            public Uri? DownloadUrl { get; init; }
            public bool SupportsAbpUrlScheme { get; init; }
            public IEnumerable<int>? SyntaxIds { get; init; }
        }
    }
}
