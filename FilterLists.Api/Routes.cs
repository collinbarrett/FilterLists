using FilterLists.Api.Queries.Handlers;

namespace FilterLists.Api;

internal static class Routes
{
    public static void MapRoutes(this WebApplication app)
    {
        app.MapGet("/lists", GetFilterLists.ExecuteAsync).Produces<IAsyncEnumerable<GetFilterLists.FilterList>>();
    }
}