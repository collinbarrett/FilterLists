using AutoMapper;
using AutoMapper.QueryableExtensions;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries
{
    public static class GetTags
    {
        public class Query : IRequest<IEnumerable<TagVm>>
        {
        }

        internal class Handler : IRequestHandler<Query, IEnumerable<TagVm>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<TagVm>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Tags
                    .OrderBy(t => t.Id)
                    .ProjectTo<TagVm>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        internal class TagVmProfile : Profile
        {
            public TagVmProfile()
            {
                CreateMap<Tag, TagVm>()
                    .ForMember(t => t.FilterListIds,
                        o => o.MapFrom(t =>
                            t.FilterListTags.Select(flt => flt.FilterListId).OrderBy(flid => flid).AsEnumerable()));
            }
        }

        public class TagVm
        {
            public int Id { get; init; }
            public string Name { get; init; } = null!;
            public string? Description { get; init; }
            public IEnumerable<int>? FilterListIds { get; init; }
        }
    }
}
