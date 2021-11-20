using FilterLists.Directory.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Api.Controllers;

public class ChangesController : BaseController
{
    private readonly IMediator _mediator;

    public ChangesController(IMemoryCache cache, IMediator mediator) : base(cache)
    {
        _mediator = mediator;
    }

    /// <summary>
    ///     Gets the changes.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The changes.</returns>
    [HttpGet]
    //[ProducesResponseType(typeof(IEnumerable<GetChanges.ChangesVm>), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        return Ok(await _mediator.Send(new GetChanges.Query(), cancellationToken));
        //return CacheGetOrCreateAsync(() => _mediator.Send(new GetChanges.Query(), cancellationToken));
    }
}
