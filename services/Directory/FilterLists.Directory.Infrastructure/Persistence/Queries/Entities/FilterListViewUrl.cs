using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListViewUrl
{
    public int Id { get; private init; }
    public int FilterListId { get; private init; }
    public FilterList FilterList { get; } = null!;
    public short SegmentNumber { get; private init; }
    public short Primariness { get; private init; }
    public Uri Url { get; private init; } = null!;
}

internal class FilterListViewUrlConfiguration : IEntityTypeConfiguration<FilterListViewUrl>
{
    public virtual void Configure(EntityTypeBuilder<FilterListViewUrl> builder)
    {
        builder.ToTable(nameof(FilterListViewUrl) + "s");
        builder.Property(u => u.SegmentNumber).HasDefaultValue(1);
        builder.Property(u => u.Primariness).HasDefaultValue(1);
        builder.HasIndex(u => new { u.FilterListId, u.SegmentNumber, u.Primariness }).IsUnique();
        builder.HasDataJsonFile<FilterListViewUrl>();
    }
}
