using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Maintainer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Url { get; set; }
        public string? EmailAddress { get; set; }
        public string? TwitterHandle { get; set; }
        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; private set; } = new HashSet<FilterListMaintainer>();
    }

    internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
    {
        public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.HasDataJsonFile<Maintainer>();
        }
    }
}