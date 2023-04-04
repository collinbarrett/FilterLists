using FilterLists.Api.Infrastructure.Entities;

namespace FilterLists.Api.Infrastructure.Context;

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

    public IQueryable<FilterList> FilterLists => _dbContext.FilterLists;
    public IQueryable<Language> Languages => _dbContext.Languages;
    public IQueryable<License> Licenses => _dbContext.Licenses;
    public IQueryable<Maintainer> Maintainers => _dbContext.Maintainers;
    public IQueryable<Software> Software => _dbContext.Software;
    public IQueryable<Syntax> Syntaxes => _dbContext.Syntaxes;
    public IQueryable<Tag> Tags => _dbContext.Tags;
}