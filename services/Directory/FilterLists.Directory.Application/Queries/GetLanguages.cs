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
    public static class GetLanguages
    {
        public class Query : IRequest<IEnumerable<LanguageVm>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<LanguageVm>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<LanguageVm>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Languages
                    .Where(l => l.FilterListLanguages.Count > 0)
                    .OrderBy(l => l.Iso6391)
                    .ProjectTo<LanguageVm>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class LanguageVmProfile : Profile
        {
            public LanguageVmProfile()
            {
                CreateMap<Language, LanguageVm>()
                    .ForMember(l => l.FilterListIds,
                        o => o.MapFrom(l =>
                            l.FilterListLanguages.Select(fll => fll.FilterListId).OrderBy(flid => flid)
                                .AsEnumerable()));
            }
        }

        public class LanguageVm
        {
            public string Iso6391 { get; } = null!;
            public string Name { get; } = null!;
            public IEnumerable<int>? FilterListIds { get; }
        }
    }
}
