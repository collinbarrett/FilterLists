using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Syntax
    {
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? Url { get; private set; }
        public ICollection<FilterListSyntax> FilterListSyntaxes { get; private set; } = new HashSet<FilterListSyntax>();
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; private set; } = new HashSet<SoftwareSyntax>();
    }

    internal class SyntaxTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Syntax
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string syntaxId = "Id";
            builder.Property<int>(syntaxId);
            builder.HasKey(syntaxId);
        }
    }
}