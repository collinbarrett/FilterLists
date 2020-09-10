using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Syntax
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Uri? Url { get; set; }
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; private set; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; private set; } = new HashSet<SoftwareSyntax>();
    }

    internal class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
    {
        public virtual void Configure(EntityTypeBuilder<Syntax> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.HasDataJsonFile<Syntax>();
        }
    }
}