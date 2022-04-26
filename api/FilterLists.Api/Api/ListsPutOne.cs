#if DEBUG

using System.Text.Json;
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

public class ListsPutOne
{
    private readonly IMediator _mediator;

    public ListsPutOne(IMediator mediator)
    {
        _mediator = mediator;
    }

    [FunctionName(nameof(ListsPutOne))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "put", Route = "lists/{name:required:length(1,255)}")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        var requestBody = await JsonSerializer.DeserializeAsync<UpsertFilterList.Command>(req.Body, cancellationToken: token);
        if (requestBody is null)
            return new BadRequestObjectResult("Invalid request body.");
        return new OkObjectResult(await _mediator.Send(requestBody, token));
    }
}

#endif