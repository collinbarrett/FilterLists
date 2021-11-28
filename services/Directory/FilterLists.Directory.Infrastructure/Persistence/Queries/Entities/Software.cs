using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Software : EntityRequiringApproval
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public Uri? HomeUrl { get; init; }
    public Uri? DownloadUrl { get; init; }
    public bool SupportsAbpUrlScheme { get; init; }
    public IEnumerable<SoftwareSyntax> SoftwareSyntaxes { get; init; } = new HashSet<SoftwareSyntax>();
    public IEnumerable<Change> Changes { get; init; } = new HashSet<Change>();
}

internal class SoftwareTypeConfiguration : EntityRequiringApprovalTypeConfiguration<Software>
{
    public override void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.Property(s => s.SupportsAbpUrlScheme)
            .HasDefaultValue(false);
        builder.HasDataJsonFileEntityRequiringApproval<Software>();
        base.Configure(builder);
    }
}
