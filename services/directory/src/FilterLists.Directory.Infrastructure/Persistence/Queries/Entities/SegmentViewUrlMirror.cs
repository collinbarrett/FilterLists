using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class SegmentViewUrlMirror
    {
        public int Id { get; private set; }
        public int SegmentViewUrlId { get; private set; }
        public SegmentViewUrl SegmentViewUrl { get; private set; } = null!;
        public Uri Url { get; private set; } = null!;
    }

    internal class ViewUrlMirrorTypeConfiguration : IEntityTypeConfiguration<SegmentViewUrlMirror>
    {
        public virtual void Configure(EntityTypeBuilder<SegmentViewUrlMirror> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(SegmentViewUrlMirror) + "s");
        }
    }
}