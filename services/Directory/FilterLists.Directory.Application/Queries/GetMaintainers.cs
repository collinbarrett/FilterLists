using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries;

public static class GetMaintainers
{
    public class Query : IRequest<List<MaintainerVm>>
    {
    }

    internal class Handler : IRequestHandler<Query, List<MaintainerVm>>
    {
        private readonly IQueryContext _context;
        private readonly IMapper _mapper;

        public Handler(IQueryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<MaintainerVm>> Handle(
            Query request,
            CancellationToken cancellationToken)
        {
            return _context.Maintainers
                .OrderBy(m => m.Id)
                .ProjectTo<MaintainerVm>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }

    internal class MaintainerVmProfile : Profile
    {
        public MaintainerVmProfile()
        {
            CreateMap<Maintainer, MaintainerVm>()
                .ForMember(m => m.FilterListIds,
                    o => o.MapFrom(m =>
                        m.FilterListMaintainers.Select(flm => flm.FilterListId).OrderBy(flid => flid)
                            .AsEnumerable()));
        }
    }

    public class MaintainerVm
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public Uri? Url { get; init; }
        public string? EmailAddress { get; init; }
        public string? TwitterHandle { get; init; }
        public IEnumerable<int>? FilterListIds { get; init; }
    }
}
