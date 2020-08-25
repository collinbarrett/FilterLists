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
    public static class GetSyntaxes
    {
        public class Query : IRequest<IEnumerable<SyntaxViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<SyntaxViewModel>>
        {
            private readonly IQueryContext _context;
            private readonly IMapper _mapper;

            public Handler(IQueryContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<SyntaxViewModel>> Handle(
                Query request,
                CancellationToken cancellationToken)
            {
                return await _context.Syntaxes
                    .ProjectTo<SyntaxViewModel>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);
            }
        }

        public class SyntaxViewModelProfile : Profile
        {
            public SyntaxViewModelProfile()
            {
                CreateMap<Syntax, SyntaxViewModel>();
            }
        }

        public class SyntaxViewModel
        {
            public int Id { get; private set; }
            public string Name { get; private set; } = null!;
            public string? Description { get; private set; }
            public Uri? Url { get; private set; }
            public IEnumerable<int>? FilterListIds { get; private set; }
            public IEnumerable<int>? SoftwareIds { get; private set; }
        }
    }
}