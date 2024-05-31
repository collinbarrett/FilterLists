using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Tag
{
    public int Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new List<FilterListTag>();
}

internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public virtual void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.Property(t => t.Name)
            .HasMaxLength(32);
        builder.HasIndex(t => t.Name)
            .IsUnique();
        builder.HasDataJsonFile<Tag>();
    }
}