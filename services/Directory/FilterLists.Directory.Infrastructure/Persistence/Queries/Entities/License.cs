using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class License
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public Uri? Url { get; private set; }
        public bool PermitsModification { get; private set; }
        public bool PermitsDistribution { get; private set; }
        public bool PermitsCommercialUse { get; private set; }
        public IReadOnlyCollection<FilterList> FilterLists { get; } = new HashSet<FilterList>();
    }

    internal class LicenseTypeConfiguration : IEntityTypeConfiguration<License>
    {
        public virtual void Configure(EntityTypeBuilder<License> builder)
        {
            builder.HasDataJsonFile<License>();
        }
    }
}
