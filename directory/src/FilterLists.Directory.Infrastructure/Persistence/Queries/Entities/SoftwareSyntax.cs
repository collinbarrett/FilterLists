using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class SoftwareSyntax
    {
        public Software Software { get; private set; } = null!;
        public Syntax Syntax { get; private set; } = null!;
    }

    internal class SoftwareSyntaxTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : SoftwareSyntax
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string softwareId = nameof(SoftwareSyntax.Software) + "Id";
            const string syntaxId = nameof(SoftwareSyntax.Syntax) + "Id";
            builder.Property<int>(softwareId);
            builder.Property<int>(syntaxId);
            builder.HasKey(softwareId, syntaxId);
        }
    }
}