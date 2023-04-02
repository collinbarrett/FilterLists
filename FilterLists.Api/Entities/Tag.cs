using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Entities;

public record Tag
{
    public int Id { get; private init; }
    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public IEnumerable<FilterListTag> FilterListTags { get; private init; } = new HashSet<FilterListTag>();
}

internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public virtual void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.Name).IsUnique();
        builder.HasDataJsonFile<Tag>();
    }
}