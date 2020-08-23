using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class SoftwareSyntax
    {
        public Software Software { get; private set; } = null!;
        public Syntax Syntax { get; private set; } = null!;
    }

    internal class SoftwareSyntaxTypeConfiguration : IEntityTypeConfiguration<SoftwareSyntax>
    {
        public virtual void Configure(EntityTypeBuilder<SoftwareSyntax> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(SoftwareSyntax) + "es");

            const string softwareId = nameof(SoftwareSyntax.Software) + "Id";
            const string syntaxId = nameof(SoftwareSyntax.Syntax) + "Id";
            builder.Property<int>(softwareId);
            builder.Property<int>(syntaxId);
            builder.HasKey(softwareId, syntaxId);
        }
    }
}