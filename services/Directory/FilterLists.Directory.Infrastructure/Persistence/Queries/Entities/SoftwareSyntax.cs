using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    [SuppressMessage("ReSharper", "ReplaceAutoPropertyWithComputedProperty")]
    public class SoftwareSyntax
    {
        public int SoftwareId { get; private set; }
        public Software Software { get; } = null!;
        public int SyntaxId { get; private set; }
        public Syntax Syntax { get; } = null!;
    }

    internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
    {
        public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
        {
            builder.ToTable(nameof(SoftwareSyntax) + "es");
            builder.HasKey(ss => new { ss.SoftwareId, ss.SyntaxId });
            builder.HasDataJsonFile<SoftwareSyntax>();
        }
    }
}
