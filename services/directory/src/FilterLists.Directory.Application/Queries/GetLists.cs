using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Application.Queries
{
    public static class GetLists
    {
        public class Query : IRequest<IEnumerable<FilterListViewModel>>
        {
        }

        public class Handler : IRequestHandler<Query, IEnumerable<FilterListViewModel>>
        {
            private readonly IQueryContext _context;

            public Handler(IQueryContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<FilterListViewModel>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                return await _context.FilterLists
                    .Select(fl => new FilterListViewModel(fl.Name))
                    .ToListAsync(cancellationToken);
            }
        }

        public class FilterListViewModel
        {
            public FilterListViewModel(string name)
            {
                Name = name;
            }

            public string Name { get; }
        }
    }
}