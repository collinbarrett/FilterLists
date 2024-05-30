using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Tag : Entity
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new HashSet<FilterListTag>();
}

internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public virtual void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.Name)
            .IsUnique();
        builder.HasDataJsonFile<Tag>();
    }
}