using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Tag : AggregateRoot
{
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new HashSet<FilterListTag>();
    public IEnumerable<Change> Changes { get; init; } = new HashSet<Change>();
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
