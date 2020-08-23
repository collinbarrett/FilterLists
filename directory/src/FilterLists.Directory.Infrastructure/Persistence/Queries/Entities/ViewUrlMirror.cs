using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlMirror
    {
        public FilterList FilterList { get; } = null!;
        public Uri Url { get; } = null!;
    }

    internal class ViewUrlMirrorTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : ViewUrlMirror
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string viewUrlMirrorId = "Id";
            builder.Property<int>(viewUrlMirrorId);
            builder.HasKey(viewUrlMirrorId);
        }
    }
}