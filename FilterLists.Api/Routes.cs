using FilterLists.Api.Queries.Context;
using FilterLists.Api.Queries.Handlers;

namespace FilterLists.Api;

internal static class Routes
{
    public static void MapRoutes(this WebApplication app)
    {
        app.MapGet("/lists",
            async (IQueryContext dbContext, CancellationToken cancellationToken) =>
                await GetFilterLists.ExecuteAsync(dbContext, cancellationToken));
    }
}