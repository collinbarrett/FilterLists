using System.Globalization;
using EFCore.NamingConventions.Internal;
using FilterLists.Directory.Domain.Aggregates;
using FilterLists.Directory.Domain.Aggregates.Changes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class ChangeTypeConfiguration : IEntityTypeConfiguration<Change>
{
    public virtual void Configure(EntityTypeBuilder<Change> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(Change))}s");
        builder.HasDiscriminator<AggregateType>(nr.RewriteName(nameof(Queries.Entities.Change.AggregateType)))
            .HasValue<FilterListChange>(AggregateType.FilterList);
        builder.Property<long>(nameof(Queries.Entities.Change.Id));
    }
}
