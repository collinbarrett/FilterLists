using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Tag
{
    public int Id { get; private init; }
    public string Name { get; private init; } = null!;
    public string? Description { get; private init; }
    public IReadOnlyCollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
}

internal class TagTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public virtual void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasDataJsonFile<Tag>();
    }
}
