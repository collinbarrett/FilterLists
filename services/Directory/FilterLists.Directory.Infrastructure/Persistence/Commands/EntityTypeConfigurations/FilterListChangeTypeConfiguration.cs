using FilterLists.Directory.Domain.Aggregates.FilterLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Change = FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Change;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListChangeTypeConfiguration : IEntityTypeConfiguration<FilterListChange>
{
    public virtual void Configure(EntityTypeBuilder<FilterListChange> builder)
    {
        builder.Property<long>(nameof(Change.FilterListId));
        builder.Property(c => c.Before)
            .HasColumnType("jsonb");
        builder.Property(c => c.After)
            .HasColumnType("jsonb");
    }
}
