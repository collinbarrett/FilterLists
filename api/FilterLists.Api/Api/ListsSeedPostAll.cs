#if DEBUG

using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Application.SeedFilterLists;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.Api;

public class ListsSeedPostAll
{
    private readonly IMediator _mediator;

    public ListsSeedPostAll(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    ///     Seeds data from the legacy relational database to the new denormalized nosql format.
    /// </summary>
    [FunctionName(nameof(ListsSeedPostAll))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = "lists/seed")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        await _mediator.Send(new SeedFilterLists.Command(), token);
        return new NoContentResult();
    }
}

#endif