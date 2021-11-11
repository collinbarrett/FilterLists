using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Syntax
    {
        public int Id { get; init; }
        public string Name { get; init; } = null!;
        public string? Description { get; init; }
        public Uri? Url { get; init; }
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; } = new HashSet<SoftwareSyntax>();
    }

    internal class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
    {
        public virtual void Configure(EntityTypeBuilder<Syntax> builder)
        {
            builder.HasDataJsonFile<Syntax>();
        }
    }
}
