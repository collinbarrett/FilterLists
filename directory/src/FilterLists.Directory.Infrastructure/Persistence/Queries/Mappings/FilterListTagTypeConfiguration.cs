using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings
{
    internal class FilterListTagTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : FilterListTag
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(FilterListTag.FilterList) + "Id";
            const string tagId = nameof(FilterListTag.Tag) + "Id";
            builder.Property<int>(filterListId);
            builder.Property<int>(tagId);
            builder.HasKey(filterListId, tagId);
        }
    }
}