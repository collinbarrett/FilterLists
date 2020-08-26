using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class SoftwareSyntax
    {
        public int SoftwareId { get; private set; }
        public Software Software { get; private set; } = null!;
        public int SyntaxId { get; private set; }
        public Syntax Syntax { get; private set; } = null!;
    }

    internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
    {
        public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.ToTable(nameof(SoftwareSyntax) + "es");
            builder.HasKey(ss => new {ss.SoftwareId, ss.SyntaxId});
            builder.HasDataJsonFile<SoftwareSyntax>();
        }
    }
}