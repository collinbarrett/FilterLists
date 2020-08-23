using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class FilterListTag
    {
        public FilterList FilterList { get; private set; } = null!;
        public Tag Tag { get; private set; } = null!;
    }

    internal class FilterListTagTypeConfiguration : IEntityTypeConfiguration<FilterListTag>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListTag> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(FilterListTag) + "s");

            const string filterListId = nameof(FilterListTag.FilterList) + "Id";
            const string tagId = nameof(FilterListTag.Tag) + "Id";
            builder.Property<int>(filterListId);
            builder.Property<int>(tagId);
            builder.HasKey(filterListId, tagId);
        }
    }
}