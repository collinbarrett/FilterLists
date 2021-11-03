using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Api.Controllers
{
    public class TagsController : BaseController
    {
        private readonly IMediator _mediator;

        public TagsController(IMemoryCache cache, IMediator mediator) : base(cache)
        {
            _mediator = mediator;
        }

        /// <summary>
        ///     Gets the tags of FilterLists.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The tags of FilterLists.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetTags.TagVm>), StatusCodes.Status200OK)]
        public Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return CacheGetOrCreateAsync(() => _mediator.Send(new GetTags.Query(), cancellationToken));
        }
    }
}
