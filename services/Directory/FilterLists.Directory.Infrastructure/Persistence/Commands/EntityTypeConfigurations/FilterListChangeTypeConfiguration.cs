using FilterLists.Directory.Domain.Aggregates.Changes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Change = FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Change;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListChangeTypeConfiguration : IEntityTypeConfiguration<FilterListChange>
{
    public virtual void Configure(EntityTypeBuilder<FilterListChange> builder)
    {
        builder.Property<int>(nameof(Change.FilterListId));
        builder.HasOne(c => c.Current)
            .WithMany(f => f.Changes)
            .HasForeignKey(nameof(Change.FilterListId));

        // TODO: share by configuring IChange<TAggregate>
        // TODO: serialize/deserialize json via value converter
        builder.Ignore(c => c.Before);
        builder.Ignore(c => c.After);
    }
}
