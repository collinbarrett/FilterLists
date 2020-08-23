using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer
    {
        public string Name { get; private set; } = null!;
        public Uri? Url { get; private set; }
        public string? EmailAddress { get; private set; }
        public string? TwitterHandle { get; private set; }
        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; private set; } = new HashSet<FilterListMaintainer>();
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