using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class ViewUrlMirror
    {
        public FilterList FilterList { get; private set; } = null!;
        public Uri Url { get; private set; } = null!;
    }

    internal class ViewUrlMirrorTypeConfiguration : IEntityTypeConfiguration<ViewUrlMirror>
    {
        public virtual void Configure(EntityTypeBuilder<ViewUrlMirror> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(ViewUrlMirror) + "s");

            const string viewUrlMirrorId = "Id";
            builder.Property<int>(viewUrlMirrorId);
            builder.HasKey(viewUrlMirrorId);
        }
    }
}