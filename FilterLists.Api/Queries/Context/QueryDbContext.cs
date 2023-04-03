using FilterLists.Api.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FilterLists.Api.Queries.Context;

internal class QueryDbContext : DbContext
{
    // TODO: does EF Core SQL Server ship with enum and/or method that provides this?
    private readonly Type[] _nvarcharTypes = { typeof(string), typeof(Uri) };

    public QueryDbContext(DbContextOptions<QueryDbContext> options) : base(options)
    {
    }

    public DbSet<FilterList> FilterLists => Set<FilterList>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<License> Licenses => Set<License>();
    public DbSet<Maintainer> Maintainers => Set<Maintainer>();
    public DbSet<Software> Software => Set<Software>();
    public DbSet<Syntax> Syntaxes => Set<Syntax>();
    public DbSet<Tag> Tags => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // MS-recommended https://learn.microsoft.com/en-us/sql/relational-databases/collations/collation-and-unicode-support?view=sql-server-ver16#SQL-collations
        modelBuilder.UseCollation("Latin1_General_100_CI_AS_SC");

        modelBuilder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);

        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            SetTableNameToTypeName(entity);
            foreach (var property in entity.GetProperties())
                SetNvarcharTo4000IfUnspecified(property);
        }
    }

    /// <summary>
    ///     Override EF Core pluralization of some table names by convention
    /// </summary>
    private static void SetTableNameToTypeName(IMutableEntityType entity)
    {
        if (entity.GetTableName() is not null)
            entity.SetTableName(entity.ClrType.Name);
    }

    /// <summary>
    ///     Default to nvarchar(4000) to allow indexes as needed
    /// </summary>
    private void SetNvarcharTo4000IfUnspecified(IMutableProperty property)
    {
        if (_nvarcharTypes.Contains(property.ClrType) &&
            property.GetMaxLength() is null)
            property.SetMaxLength(4000);
    }
}