using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class SegmentViewUrlMirror
    {
        public SegmentViewUrl SegmentViewUrl { get; private set; } = null!;
        public Uri Url { get; private set; } = null!;
    }

    internal class ViewUrlMirrorTypeConfiguration : IEntityTypeConfiguration<SegmentViewUrlMirror>
    {
        public virtual void Configure(EntityTypeBuilder<SegmentViewUrlMirror> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(SegmentViewUrlMirror) + "s");

            const string segmentViewUrlMirrorId = "Id";
            builder.Property<int>(segmentViewUrlMirrorId);
            builder.HasKey(segmentViewUrlMirrorId);
        }
    }
}