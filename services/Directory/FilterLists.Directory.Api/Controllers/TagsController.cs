using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagsController : BaseController
    {
        private readonly IMediator _mediator;

        public TagsController(IMemoryCache cache, IMediator mediator) : base(cache)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetTags.TagVm>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return await CacheGetOrCreateAsync(() => _mediator.Send(new GetTags.Query(), cancellationToken));
        }
    }
}