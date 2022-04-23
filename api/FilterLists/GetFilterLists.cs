using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace FilterLists.Api.FilterLists;

public class GetFilterLists
{
    private readonly IFilterListRepository _repo;

    public GetFilterLists(IFilterListRepository repo)
    {
        _repo = repo;
    }

    [FunctionName("GetFilterLists")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "lists")]
        HttpRequest req,
        ILogger log,
        CancellationToken cancellationToken)
    {
        return new OkObjectResult(await _repo.GetListsAsync(cancellationToken));
    }
}