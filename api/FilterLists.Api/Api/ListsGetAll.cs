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

public class ListsGetAll
{
    private readonly IMediator _mediator;

    public ListsGetAll(IMediator mediator)
    {
        _mediator = mediator;
    }

    [FunctionName(nameof(ListsGetAll))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "lists")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        // TODO: page response(s)?
        // TODO: query param flag normal v. light
        return true
            ? new OkObjectResult(await _mediator.Send(new GetFilterListSummaries.Query(), token))
            : new OkObjectResult(await _mediator.Send(new GetFilterListSummariesLight.Query(), token));
    }
}