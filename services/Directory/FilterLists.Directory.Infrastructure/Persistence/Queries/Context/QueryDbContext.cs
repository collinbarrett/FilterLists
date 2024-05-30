using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

public class QueryDbContext(DbContextOptions<QueryDbContext> options) : DbContext(options)
{
    public DbSet<FilterList> FilterLists => Set<FilterList>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<License> Licenses => Set<License>();
    public DbSet<Maintainer> Maintainers => Set<Maintainer>();
    public DbSet<Software> Software => Set<Software>();
    public DbSet<Syntax> Syntaxes => Set<Syntax>();
    public DbSet<Tag> Tags => Set<Tag>();

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        throw new InvalidOperationException("This context is read-only.");
    }

    public override Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default)
    {
        throw new InvalidOperationException("This context is read-only.");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);
    }
}