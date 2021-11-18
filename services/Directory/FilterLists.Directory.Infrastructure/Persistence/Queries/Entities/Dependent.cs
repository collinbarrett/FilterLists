using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Dependent
{
    public int DependencyFilterListId { get; init; }
    public FilterList DependencyFilterList { get; } = null!;
    public int DependentFilterListId { get; init; }
    public FilterList DependentFilterList { get; } = null!;
}

internal class DependentTypeConfiguration : IEntityTypeConfiguration<Dependent>
{
    public virtual void Configure(EntityTypeBuilder<Dependent> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(Dependent))}s");
        builder.HasKey(d => new { d.DependencyFilterListId, d.DependentFilterListId });
        builder.HasOne(d => d.DependencyFilterList)
            .WithMany(fl => fl.DependentFilterLists)
            .HasForeignKey(d => d.DependencyFilterListId)
            .HasConstraintName("fk_dependents_filter_lists_dependency_filter_list_id");
        builder.HasOne(d => d.DependentFilterList)
            .WithMany(fl => fl.DependencyFilterLists)
            .HasForeignKey(d => d.DependentFilterListId)
            .HasConstraintName("fk_dependents_filter_lists_dependent_filter_list_id");
        builder.HasDataJsonFile<Dependent>();
    }
}
