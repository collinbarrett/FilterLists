using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Mappings
{
    internal class SoftwareSyntaxTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : SoftwareSyntax
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string softwareId = nameof(SoftwareSyntax.Software) + "Id";
            const string syntaxId = nameof(SoftwareSyntax.Syntax) + "Id";
            builder.Property<ushort>(softwareId);
            builder.Property<ushort>(syntaxId);
            builder.HasKey(softwareId, syntaxId);
        }
    }
}