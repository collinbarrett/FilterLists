using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

public sealed class QueryDbContext : DbContext
{
    private const string ReadOnlyErrorMessage = "This context is read-only and cannot save changes.";

    public QueryDbContext(DbContextOptions<QueryDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public IQueryable<FilterList> FilterLists => Set<FilterList>();
    public IQueryable<Language> Languages => Set<Language>();
    public IQueryable<License> Licenses => Set<License>();
    public IQueryable<Maintainer> Maintainers => Set<Maintainer>();
    public IQueryable<Software> Software => Set<Software>();
    public IQueryable<Syntax> Syntaxes => Set<Syntax>();
    public IQueryable<Tag> Tags => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.UseCollation("Latin1_General_100_CI_AS_SC");
        modelBuilder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);
    }

    public override int SaveChanges()
    {
        throw new InvalidOperationException(ReadOnlyErrorMessage);
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        throw new InvalidOperationException(ReadOnlyErrorMessage);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new InvalidOperationException(ReadOnlyErrorMessage);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default)
    {
        throw new InvalidOperationException(ReadOnlyErrorMessage);
    }
}