using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Queries.Entities;

internal record Tag
{
    public int Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new HashSet<FilterListTag>();
}

internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public virtual void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.Name).IsUnique();
        builder.HasDataJsonFile<Tag>();
    }
}