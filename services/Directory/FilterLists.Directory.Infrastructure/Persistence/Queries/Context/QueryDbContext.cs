using FilterLists.Directory.Domain.Aggregates;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

public class QueryDbContext : DbContext
{
    static QueryDbContext()
    {
#pragma warning disable CS0618
        NpgsqlConnection.GlobalTypeMapper.MapEnum<AggregateType>();
#pragma warning restore CS0618
    }

    public QueryDbContext(DbContextOptions<QueryDbContext> options) : base(options) { }

    public DbSet<Change> Changes => Set<Change>();
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
        modelBuilder.HasSequence($"EntityFrameworkHiLoSequence-{nameof(FilterListViewUrl)}")
            .StartsAt(3000)
            .IncrementsBy(3);
        modelBuilder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);
        modelBuilder.HasPostgresEnum<AggregateType>();
    }
}
