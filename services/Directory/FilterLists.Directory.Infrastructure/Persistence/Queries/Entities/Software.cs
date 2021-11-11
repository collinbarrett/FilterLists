using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public string? Description { get; init; }
        public Uri? HomeUrl { get; init; }
        public Uri? DownloadUrl { get; init; }
        public bool SupportsAbpUrlScheme { get; init; }
        public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; } = new HashSet<SoftwareSyntax>();
    }

    internal class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
    {
        public virtual void Configure(EntityTypeBuilder<Software> builder)
        {
            builder.HasDataJsonFile<Software>();
        }
    }
}
