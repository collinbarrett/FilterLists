using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlPartial
    {
        public FilterList FilterList { get; private set; } = null!;
        public int Position { get; private set; }
        public Uri Url { get; } = null!;
    }

    internal class ViewUrlPartialTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : ViewUrlPartial
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(ViewUrlPartial.FilterList) + "Id";
            builder.Property<int>(filterListId);
            builder.HasKey(filterListId, nameof(ViewUrlPartial.Position));
        }
    }
}