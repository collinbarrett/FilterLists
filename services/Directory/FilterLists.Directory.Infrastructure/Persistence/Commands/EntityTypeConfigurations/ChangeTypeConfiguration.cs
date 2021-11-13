using FilterLists.Directory.Domain.Aggregates.Changes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class ChangeTypeConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
        builder.Property<int>(nameof(Queries.Entities.Change.Id));
    }
}
