using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Application;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("lists")]
    public class FilterListsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FilterListsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<FilterList>> Get(CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetLists.Query(), cancellationToken);
        }
    }
}