using HotChocolate.AzureFunctions;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace FilterLists.Api.Api;

public class GraphQlFunction
{
    private readonly IGraphQLRequestExecutor _executor;

    public GraphQlFunction(IGraphQLRequestExecutor executor)
    {
        _executor = executor;
    }

    [Function(nameof(GraphQlFunction))]
    public Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")]
        HttpRequestData request)
    {
        return _executor.ExecuteAsync(request);
    }
}