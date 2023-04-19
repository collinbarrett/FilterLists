using System.Net;
using HotChocolate.AzureFunctions;
using HotChocolate.Execution;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace FilterLists.Api;

// ReSharper disable once InconsistentNaming
public class GraphQLFunction
{
    private readonly IGraphQLRequestExecutor _executor;
    private readonly IRequestExecutorResolver _executorResolver;

    public GraphQLFunction(IGraphQLRequestExecutor executor, IRequestExecutorResolver executorResolver)
    {
        _executor = executor;
        _executorResolver = executorResolver;
    }

    [Function(nameof(GraphQLFunction))]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "graphql/{**slug}")]
        HttpRequestData request,
        CancellationToken cancellationToken)
    {
        // serve SDL in production for API Gateway
        var environmentVariable = Environment.GetEnvironmentVariable("AZURE_FUNCTIONS_ENVIRONMENT");
        if (environmentVariable != "Development" &&
            request.Method.ToUpperInvariant() == "GET")
        {
            var executor = await _executorResolver.GetRequestExecutorAsync(cancellationToken: cancellationToken);
            var schemaText = executor.Schema.ToString();
            var response = request.CreateResponse(HttpStatusCode.OK);
            await response.WriteStringAsync(schemaText, cancellationToken);
            return response;
        }

        return await _executor.ExecuteAsync(request);
    }
}