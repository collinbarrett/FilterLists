using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag
    {
        public string Name { get; } = null!;
        public string? Description { get; private set; }
        public ICollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
    }

    internal class TagTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Tag
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string tagId = "Id";
            builder.Property<int>(tagId);
            builder.HasKey(tagId);
        }
    }
}