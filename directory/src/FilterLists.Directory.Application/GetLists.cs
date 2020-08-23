using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Facade;
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
            private readonly IQueryDirectory _context;

            public Handler(IQueryDirectory context)
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