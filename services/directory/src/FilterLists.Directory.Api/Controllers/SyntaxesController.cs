using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SyntaxesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SyntaxesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetSyntaxes.Query(), cancellationToken));
        }
    }
}