using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.FilterLists;

public static class GetFilterList
{
    [FunctionName("GetFilterList")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "lists/{id:int}")]
        HttpRequest req,
        ILogger log,
        CancellationToken cancellationToken)
    {
        return new OkObjectResult(new { Name = "EasyList" });
    }
}