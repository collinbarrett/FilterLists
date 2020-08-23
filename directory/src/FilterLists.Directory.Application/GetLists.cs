using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application
{
    public static class GetLists
    {
        public class Query : IRequest<IEnumerable<FilterList>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<FilterList>>
        {
            private readonly IQueryContext _context;

            public Handler(IQueryContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<FilterList>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.FilterLists.ToListAsync(cancellationToken);
            }
        }
    }
}