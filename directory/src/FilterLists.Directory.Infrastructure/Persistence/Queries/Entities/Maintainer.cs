using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Maintainer
    {
        public string Name { get; private set; } = null!;
        public Uri? Url { get; private set; }
        public string? EmailAddress { get; private set; }
        public string? TwitterHandle { get; private set; }
        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; private set; } = new HashSet<FilterListMaintainer>();
    }

    internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
    {
        public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string maintainerId = "Id";
            builder.Property<int>(maintainerId);
            builder.HasKey(maintainerId);
        }
    }
}