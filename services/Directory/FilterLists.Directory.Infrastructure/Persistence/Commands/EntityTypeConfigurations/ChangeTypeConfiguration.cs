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
        builder.Property<int>(nameof(Queries.Entities.Change.Id));

        // TODO: TDiscriminator should really be AggregateType rather than string but needs name rewriting
        builder.HasDiscriminator<string>(nr.RewriteName(nameof(Queries.Entities.Change.AggregateType)))
            .HasValue<FilterListChange>(nr.RewriteName(nameof(AggregateType.FilterList)));
    }
}
