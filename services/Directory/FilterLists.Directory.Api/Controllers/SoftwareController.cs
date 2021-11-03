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
    public class SoftwareController : BaseController
    {
        private readonly IMediator _mediator;

        public SoftwareController(IMemoryCache cache, IMediator mediator) : base(cache)
        {
            _mediator = mediator;
        }

        /// <summary>
        ///     Gets the software that subscribes to FilterLists.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The software that subscribes to FilterLists.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetSoftware.SoftwareVm>), StatusCodes.Status200OK)]
        public Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return CacheGetOrCreateAsync(() => _mediator.Send(new GetSoftware.Query(), cancellationToken));
        }
    }
}
