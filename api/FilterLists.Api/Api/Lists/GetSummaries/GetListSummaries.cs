using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.Api.Lists.GetSummaries;

public class GetListSummaries
{
    private readonly IFilterListRepository _repo;

    public GetListSummaries(IFilterListRepository repo)
    {
        _repo = repo;
    }

    [FunctionName(nameof(GetListSummaries))]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "lists")]
        HttpRequest req,
        ILogger log,
        CancellationToken token)
    {
        // TODO: query param flagging normal v. light
        if (true)
        {
            // TODO: stream results https://github.com/Azure/Azure-Functions/issues/1414
            var models = await _repo.GetFilterListSummariesAsync(token).ToListAsync(token);
            return new OkObjectResult(models);
        }
        else
        {
            // TODO: page response?

            // TODO: stream results https://github.com/Azure/Azure-Functions/issues/1414
            var models = await _repo.GetFilterListLightSummariesAsync(token).ToListAsync(token);
            return new OkObjectResult(models);
        }
    }
}