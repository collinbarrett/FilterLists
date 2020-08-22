using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings
{
    internal class FilterListMaintainerTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : FilterListMaintainer
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(FilterListMaintainer.FilterList) + "Id";
            const string maintainerId = nameof(FilterListMaintainer.Maintainer) + "Id";
            builder.Property<ushort>(filterListId);
            builder.Property<ushort>(maintainerId);
            builder.HasKey(filterListId, maintainerId);
        }
    }
}