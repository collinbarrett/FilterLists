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
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public string? Description { get; init; }
        public Uri? Url { get; init; }
        public IEnumerable<int> FilterListIds { get; init; } = new HashSet<int>();
        public IEnumerable<int> SoftwareIds { get; init; } = new HashSet<int>();
    }
}
