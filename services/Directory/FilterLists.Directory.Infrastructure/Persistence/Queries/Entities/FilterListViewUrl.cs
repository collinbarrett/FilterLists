using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterListViewUrl
    {
        public int Id { get; set; }
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; } = null!;
        public short SegmentNumber { get; set; }
        public short Primariness { get; set; }
        public Uri Url { get; set; } = null!;
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
}
