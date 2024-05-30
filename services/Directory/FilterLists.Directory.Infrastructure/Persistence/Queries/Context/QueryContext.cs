using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

internal sealed class QueryContext(QueryDbContext dbContext) : IQueryContext, IAsyncDisposable, IDisposable
{
    public ValueTask DisposeAsync()
    {
        return dbContext.DisposeAsync();
    }

    void IDisposable.Dispose()
    {
        dbContext.Dispose();
    }

    public IQueryable<FilterList> FilterLists => dbContext.FilterLists.AsNoTracking();
    public IQueryable<Language> Languages => dbContext.Languages.AsNoTracking();
    public IQueryable<License> Licenses => dbContext.Licenses.AsNoTracking();
    public IQueryable<Maintainer> Maintainers => dbContext.Maintainers.AsNoTracking();
    public IQueryable<Software> Software => dbContext.Software.AsNoTracking();
    public IQueryable<Syntax> Syntaxes => dbContext.Syntaxes.AsNoTracking();
    public IQueryable<Tag> Tags => dbContext.Tags.AsNoTracking();
}