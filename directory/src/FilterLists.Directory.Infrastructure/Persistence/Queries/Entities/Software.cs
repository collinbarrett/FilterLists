using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software
    {
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? HomeUrl { get; private set; }
        public Uri? DownloadUrl { get; private set; }
        public bool SupportsAbpUrlScheme { get; private set; }
        public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; private set; } = new HashSet<SoftwareSyntax>();
    }

    internal class SoftwareTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Software
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string softwareId = "Id";
            builder.Property<int>(softwareId);
            builder.HasKey(softwareId);
        }
    }
}