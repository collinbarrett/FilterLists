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
    public class SyntaxesController : BaseController
    {
        private readonly IMediator _mediator;

        public SyntaxesController(IMemoryCache cache, IMediator mediator) : base(cache)
        {
            _mediator = mediator;
        }

        /// <summary>
        ///     Gets the syntaxes of FilterLists.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The syntaxes of FilterLists.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetSyntaxes.SyntaxVm>), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return await CacheGetOrCreateAsync(() => _mediator.Send(new GetSyntaxes.Query(), cancellationToken));
        }
    }
}
