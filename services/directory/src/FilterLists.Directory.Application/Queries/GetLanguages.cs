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
    public static class GetLanguages
    {
        public class Query : IRequest<IEnumerable<LanguageViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<LanguageViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<LanguageViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Languages
                    .ProjectTo<LanguageViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class LicenseViewModelProfile : Profile
        {
            public LicenseViewModelProfile()
            {
                CreateMap<Language, LanguageViewModel>();
            }
        }

        public class LanguageViewModel
        {
            public string Iso6391 { get; private set; } = null!;
            public string Name { get; private set; } = null!;
            public IEnumerable<int>? FilterListIds { get; private set; }
        }
    }
}