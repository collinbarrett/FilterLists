using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Api.Lists.Put.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.Api.Lists.Put;

public static class PutList
{
    [FunctionName(nameof(PutList))]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "put", Route = "lists/{name}")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        var requestBody = await JsonSerializer.DeserializeAsync<FilterList>(req.Body, cancellationToken: token);

        // if no approval token
        // log to pending changes
        // else
        // upsert
        // update any changed child entities on other lists

        return new AcceptedResult();
    }
}