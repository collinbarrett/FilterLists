using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Application;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.Api;

public class ListsGetOne
{
    private readonly IMediator _mediator;

    public ListsGetOne(IMediator mediator)
    {
        _mediator = mediator;
    }

    [FunctionName(nameof(ListsGetOne))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "lists/{id:long:required}")]
        HttpRequest req,
        long id,
        ILogger log,
        CancellationToken token)
    {
        return new OkObjectResult(await _mediator.Send(new GetFilterListDetails.Query { Id = id }, token));
    }
}