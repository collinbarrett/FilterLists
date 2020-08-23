using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Tag
    {
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; private set; } = new HashSet<FilterListTag>();
    }

    internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
    {
        public virtual void Configure(EntityTypeBuilder<Tag> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string tagId = "Id";
            builder.Property<int>(tagId);
            builder.HasKey(tagId);
        }
    }
}