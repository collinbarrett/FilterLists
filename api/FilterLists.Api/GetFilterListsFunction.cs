using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Api.Queries.Context;
using FilterLists.Api.Queries.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace FilterLists.Api;

internal class GetFilterListsFunction
{
    private readonly IQueryContext _queryContext;

    public GetFilterListsFunction(IQueryContext queryContext)
    {
        _queryContext = queryContext;
    }

    [FunctionName("GetFilterListsFunction")]
    public Task<List<GetFilterLists.FilterList>> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = "lists")]
        HttpRequest req,
        CancellationToken cancellationToken)
    {
        return GetFilterLists.ExecuteAsync(_queryContext, cancellationToken);
    }
}