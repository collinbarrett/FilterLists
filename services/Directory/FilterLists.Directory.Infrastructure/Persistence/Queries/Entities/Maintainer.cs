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
        public Uri? Url { get; set; }
        public string? EmailAddress { get; set; }
        public string? TwitterHandle { get; set; }

        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; } =
            new HashSet<FilterListMaintainer>();
    }

    internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
    {
        public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
        {
            builder.HasDataJsonFile<Maintainer>();
        }
    }
}
