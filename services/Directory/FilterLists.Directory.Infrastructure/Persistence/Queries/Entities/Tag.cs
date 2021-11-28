using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Tag : EntityRequiringApproval
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new HashSet<FilterListTag>();
    public IEnumerable<Change> Changes { get; init; } = new HashSet<Change>();
}

internal class TagTypeConfiguration : EntityRequiringApprovalTypeConfiguration<Tag>
{
    public override void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasIndex(t => t.Name)
            .IsUnique();
        builder.HasDataJsonFileEntityRequiringApproval<Tag>();
        base.Configure(builder);
    }
}
