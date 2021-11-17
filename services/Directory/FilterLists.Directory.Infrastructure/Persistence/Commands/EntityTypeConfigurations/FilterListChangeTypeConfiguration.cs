using FilterLists.Directory.Domain.Aggregates.Changes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListChangeTypeConfiguration : IEntityTypeConfiguration<FilterListChange>
{
    public virtual void Configure(EntityTypeBuilder<FilterListChange> builder)
    {
        // TODO: share by configuring IChange<TAggregate>
        // TODO: serialize/deserialize json via value converter
        builder.Ignore(c => c.Before);
        builder.Ignore(c => c.After);
    }
}
