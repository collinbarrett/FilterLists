using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("lists")]
    public class FilterListsController : ControllerBase
    {
        private readonly IQueryDirectory _queryContext;

        public FilterListsController(IQueryDirectory queryContext)
        {
            _queryContext = queryContext;
        }

        [HttpGet]
        public async Task<IEnumerable<FilterList>> Get(CancellationToken cancellationToken)
        {
            return await _queryContext.FilterLists.ToListAsync(cancellationToken);
        }
    }
}