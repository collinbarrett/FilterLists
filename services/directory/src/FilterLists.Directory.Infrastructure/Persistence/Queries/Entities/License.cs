using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // TODO: add to seed data
        public string? GitHubKey { get; set; }

        public Uri? Url { get; set; }
        public IReadOnlyCollection<FilterList> FilterLists { get; private set; } = new HashSet<FilterList>();

        // TODO: rm or capture permissiveX from seed data
    }

    internal class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
    {
        public virtual void Configure(EntityTypeBuilder<License> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.HasDataJsonFile<License>();
        }
    }
}