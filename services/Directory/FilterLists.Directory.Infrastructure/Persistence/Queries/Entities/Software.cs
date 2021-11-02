using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Software
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? HomeUrl { get; private set; }
        public Uri? DownloadUrl { get; private set; }
        public bool SupportsAbpUrlScheme { get; private set; }
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
