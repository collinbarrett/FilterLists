using FilterLists.Directory.Domain.Aggregates.Changes;
using FilterLists.Directory.Domain.Aggregates.FilterLists;
using FilterLists.Directory.Domain.Aggregates.Licenses;
using FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Context;

internal class CommandDbContext : DbContext, ICommandContext
{
    public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
    {
    }

    public DbSet<Change> Changes => Set<Change>();
    public DbSet<FilterList> FilterLists => Set<FilterList>();
    public DbSet<License> Licenses => Set<License>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly,
            type => type.Namespace == typeof(FilterListTypeConfiguration).Namespace);
    }
}
