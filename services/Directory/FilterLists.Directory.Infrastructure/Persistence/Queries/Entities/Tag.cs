using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
    }

    internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
    {
        public virtual void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasDataJsonFile<Tag>();
        }
    }
}
