using HotChocolate.AzureFunctions;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace FilterLists.Api;

// ReSharper disable once InconsistentNaming
public class GraphQLFunction
{
    private readonly IGraphQLRequestExecutor _executor;

    public GraphQLFunction(IGraphQLRequestExecutor executor)
    {
        _executor = executor;
    }

    [Function(nameof(GraphQLFunction))]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "graphql" /*"graphql/{**slug}"*/)]
        HttpRequestData request,
        CancellationToken cancellationToken)
    {
        return await _executor.ExecuteAsync(request);
    }
}