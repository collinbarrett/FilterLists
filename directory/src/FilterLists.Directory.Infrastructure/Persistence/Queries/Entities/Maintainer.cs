using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer
    {
        public string Name { get; } = null!;
        public Uri? Url { get; private set; }
        public string? EmailAddress { get; private set; }
        public string? TwitterHandle { get; private set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
    }

    internal class MaintainerTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Maintainer
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string maintainerId = "Id";
            builder.Property<int>(maintainerId);
            builder.HasKey(maintainerId);
        }
    }
}