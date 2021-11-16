using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Software
{
    public int Id { get; private init; }
    public string Name { get; private init; } = null!;
    public string? Description { get; private init; }
    public Uri? HomeUrl { get; private init; }
    public Uri? DownloadUrl { get; private init; }
    public bool SupportsAbpUrlScheme { get; private init; }
    public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; } = new HashSet<SoftwareSyntax>();
}

internal class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
{
    public virtual void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasDataJsonFile<Software>();
    }
}
