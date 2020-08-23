using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License
    {
        public string Name { get; private set; } = null!;
        public string? GitHubKey { get; private set; }
        public Uri? Url { get; private set; }
        public ICollection<FilterList> FilterLists { get; private set; } = new HashSet<FilterList>();
    }

    internal class LicenseTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : License
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string licenseId = "Id";
            builder.Property<int>(licenseId);
            builder.HasKey(licenseId);
        }
    }
}