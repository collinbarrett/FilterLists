using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class ViewUrlPartial
    {
        public FilterList FilterList { get; private set; } = null!;
        public int Position { get; private set; }
        public Uri Url { get; private set; } = null!;
    }

    internal class ViewUrlPartialTypeConfiguration : IEntityTypeConfiguration<ViewUrlPartial>
    {
        public virtual void Configure(EntityTypeBuilder<ViewUrlPartial> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(ViewUrlPartial) + "s");

            const string filterListId = nameof(ViewUrlPartial.FilterList) + "Id";
            builder.Property<int>(filterListId);
            builder.HasKey(filterListId, nameof(ViewUrlPartial.Position));
        }
    }
}