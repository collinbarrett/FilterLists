using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Context;

// TODO: explicitly make more readonly-ish
public sealed class QueryDbContext(DbContextOptions<QueryDbContext> options) : DbContext(options)
{
    public DbSet<FilterList> FilterLists => Set<FilterList>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<License> Licenses => Set<License>();
    public DbSet<Maintainer> Maintainers => Set<Maintainer>();
    public DbSet<Software> Software => Set<Software>();
    public DbSet<Syntax> Syntaxes => Set<Syntax>();
    public DbSet<Tag> Tags => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_100_CI_AS_SC");
        modelBuilder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);
    }
}