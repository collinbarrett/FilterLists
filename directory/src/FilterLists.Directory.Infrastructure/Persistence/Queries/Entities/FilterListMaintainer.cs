using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class FilterListMaintainer
    {
        public FilterList FilterList { get; private set; } = null!;
        public Maintainer Maintainer { get; private set; } = null!;
    }

    internal class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
    {
        public virtual void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = nameof(FilterListMaintainer.FilterList) + "Id";
            const string maintainerId = nameof(FilterListMaintainer.Maintainer) + "Id";
            builder.Property<int>(filterListId);
            builder.Property<int>(maintainerId);
            builder.HasKey(filterListId, maintainerId);
        }
    }
}