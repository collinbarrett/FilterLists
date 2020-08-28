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
    public static class GetTags
    {
        public class Query : IRequest<IEnumerable<TagViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<TagViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<TagViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Tags
                    .OrderBy(t => t.Id)
                    .ProjectTo<TagViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class TagViewModelProfile : Profile
        {
            public TagViewModelProfile()
            {
                CreateMap<Tag, TagViewModel>()
                    .ForMember(t => t.FilterListIds,
                        o => o.MapFrom(t =>
                            t.FilterListTags.Select(flt => flt.FilterListId).OrderBy(flid => flid)));
            }
        }

        public class TagViewModel
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public string? Description { get; private set; }
            public IEnumerable<int>? FilterListIds { get; private set; }
        }
    }
}