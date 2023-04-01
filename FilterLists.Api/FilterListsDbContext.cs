using FilterLists.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FilterLists.Api;

public class FilterListsDbContext : DbContext
{
    private readonly Type[] _nvarcharTypes = { typeof(string), typeof(Uri) };

    public FilterListsDbContext(DbContextOptions<FilterListsDbContext> options) : base(options)
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
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);

        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            SetTableNameToTypeName(entity);
            foreach (var property in entity.GetProperties())
                SetNvarchar4000IfUnspecified(property);
        }
    }

    private static void SetTableNameToTypeName(IMutableEntityType entity)
    {
        if (entity.GetTableName() is not null)
            entity.SetTableName(entity.ClrType.Name);
    }

    private void SetNvarchar4000IfUnspecified(IMutableProperty property)
    {
        if (_nvarcharTypes.Contains(property.ClrType) &&
            property.GetMaxLength() is null)
            property.SetMaxLength(4000);
    }
}