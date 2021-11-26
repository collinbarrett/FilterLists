using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListViewUrl
{
    public long Id { get; init; }
    public long FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public short SegmentNumber { get; init; }
    public short Primariness { get; init; }
    public Uri Url { get; init; } = default!;
}

internal class FilterListViewUrlConfiguration : IEntityTypeConfiguration<FilterListViewUrl>
{
    public virtual void Configure(EntityTypeBuilder<FilterListViewUrl> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(FilterListViewUrl))}s");
        builder.Property(u => u.SegmentNumber)
            .HasDefaultValue(1);
        builder.Property(u => u.Primariness)
            .HasDefaultValue(1);
        builder.HasIndex(u => new { u.FilterListId, u.SegmentNumber, u.Primariness })
            .IsUnique();
        builder.HasQueryFilter(u => u.FilterList.IsApproved);
        builder.HasDataJsonFile<FilterListViewUrl>();
    }
}
