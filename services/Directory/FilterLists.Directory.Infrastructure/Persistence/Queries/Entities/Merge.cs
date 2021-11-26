using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Merge
{
    public long IncludedInFilterListId { get; init; }
    public FilterList IncludedInFilterList { get; init; } = default!;
    public long IncludesFilterListId { get; init; }
    public FilterList IncludesFilterList { get; init; } = default!;
}

internal class MergeTypeConfiguration : IEntityTypeConfiguration<Merge>
{
    public virtual void Configure(EntityTypeBuilder<Merge> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(Merge))}s");
        builder.HasKey(m => new { m.IncludedInFilterListId, m.IncludesFilterListId });
        builder.HasOne(m => m.IncludedInFilterList)
            .WithMany(fl => fl.IncludesFilterLists)
            .HasForeignKey(m => m.IncludedInFilterListId)
            .HasConstraintName("fk_merges_filter_lists_included_in_filter_list_id");
        builder.HasOne(m => m.IncludesFilterList)
            .WithMany(fl => fl.IncludedInFilterLists)
            .HasForeignKey(m => m.IncludesFilterListId)
            .HasConstraintName("fk_merges_filter_lists_includes_filter_list_id");
        builder.HasQueryFilter(m => m.IncludedInFilterList.IsApproved && m.IncludesFilterList.IsApproved);
        builder.HasDataJsonFile<Merge>();
    }
}
