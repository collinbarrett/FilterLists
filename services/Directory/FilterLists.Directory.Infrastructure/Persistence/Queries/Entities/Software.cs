using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Uri? HomeUrl { get; set; }
        public Uri? DownloadUrl { get; set; }
        public bool SupportsAbpUrlScheme { get; set; }
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
