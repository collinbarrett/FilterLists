#if DEBUG

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
    [ProducesResponseType(typeof(List<GetChanges.ChangeVm>), StatusCodes.Status200OK)]
    public Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        return CacheGetOrCreateAsync(() => _mediator.Send(new GetChanges.Query(), cancellationToken));
    }

    /// <summary>
    ///     Gets the change.
    /// </summary>
    /// <param name="id">The identifier of the change.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The change.</returns>
    [HttpGet("{id:long}")]
    [ProducesResponseType(typeof(GetChange.ChangeVm), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public Task<IActionResult> GetDetails(long id, CancellationToken cancellationToken)
    {
        return CacheGetOrCreateAsync(() => _mediator.Send(new GetChange.Query(id), cancellationToken), id);
    }
}

#endif
