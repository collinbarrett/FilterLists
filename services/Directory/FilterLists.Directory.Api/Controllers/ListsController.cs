using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ListsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetLists.ListViewModel>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetLists.Query(), cancellationToken));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetListDetails.ListViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetDetails(int id, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetListDetails.Query(id), cancellationToken));
        }
    }
}