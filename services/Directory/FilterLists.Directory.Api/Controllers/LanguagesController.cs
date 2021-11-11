using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Api.Controllers
{
    public class LanguagesController : BaseController
    {
        private readonly IMediator _mediator;

        public LanguagesController(IMemoryCache cache, IMediator mediator) : base(cache)
        {
            _mediator = mediator;
        }

        /// <summary>
        ///     Gets the languages targeted by FilterLists.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The languages targeted by FilterLists.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetLanguages.LanguageVm>), StatusCodes.Status200OK)]
        public Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return CacheGetOrCreateAsync(() => _mediator.Send(new GetLanguages.Query(), cancellationToken));
        }
    }
}
