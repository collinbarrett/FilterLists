using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Syntax
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? Url { get; private set; }
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
