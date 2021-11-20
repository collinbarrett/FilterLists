using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Tag : AggregateRoot
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public IReadOnlyCollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
}

internal class TagTypeConfiguration : AggregateRootTypeConfiguration<Tag>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.Name)
            .IsUnique();
        builder.HasDataJsonFileAggregate<Tag>();
        base.Configure(builder);
    }
}
