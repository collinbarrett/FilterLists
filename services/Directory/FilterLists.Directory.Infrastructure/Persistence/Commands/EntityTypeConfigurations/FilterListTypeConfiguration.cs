using System.Globalization;
using EFCore.NamingConventions.Internal;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilterList = FilterLists.Directory.Domain.Aggregates.FilterLists.FilterList;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public virtual void Configure(EntityTypeBuilder<FilterList> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.HasMany(f => f.UpstreamFilterLists)
            .WithMany(f => f.ForkFilterLists)
            .UsingEntity(f => f.ToTable($"{nr.RewriteName(nameof(Fork))}s"));
        builder.HasMany(f => f.IncludedInFilterLists)
            .WithMany(f => f.IncludesFilterLists)
            .UsingEntity(f => f.ToTable($"{nr.RewriteName(nameof(Merge))}s"));
        builder.HasMany(f => f.DependencyFilterLists)
            .WithMany(f => f.DependentFilterLists)
            .UsingEntity(f => f.ToTable($"{nr.RewriteName(nameof(Dependent))}s"));
        builder.HasMany(f => f.Changes)
            .WithOne()
            .HasForeignKey(nameof(Change.FilterListId));
        builder.Navigation(f => f.Changes)
            .AutoInclude();
        builder.Navigation(f => f.ViewUrls)
            .AutoInclude();
    }
}
