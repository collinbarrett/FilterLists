using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

internal sealed class QueryContext : IQueryContext, IAsyncDisposable, IDisposable
{
    private readonly QueryDbContext _dbContext;

    public QueryContext(QueryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ValueTask DisposeAsync()
    {
        return _dbContext.DisposeAsync();
    }

    void IDisposable.Dispose()
    {
        _dbContext.Dispose();
    }

    public IQueryable<Change> Changes => _dbContext.Changes.AsNoTracking();
    public IQueryable<FilterList> FilterLists => _dbContext.FilterLists.AsNoTracking();
    public IQueryable<Language> Languages => _dbContext.Languages.AsNoTracking();
    public IQueryable<License> Licenses => _dbContext.Licenses.AsNoTracking();
    public IQueryable<Maintainer> Maintainers => _dbContext.Maintainers.AsNoTracking();
    public IQueryable<Software> Software => _dbContext.Software.AsNoTracking();
    public IQueryable<Syntax> Syntaxes => _dbContext.Syntaxes.AsNoTracking();
    public IQueryable<Tag> Tags => _dbContext.Tags.AsNoTracking();
}
