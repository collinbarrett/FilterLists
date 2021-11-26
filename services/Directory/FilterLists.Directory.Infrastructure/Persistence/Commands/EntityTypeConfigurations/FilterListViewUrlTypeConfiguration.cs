using System.Globalization;
using EFCore.NamingConventions.Internal;
using FilterLists.Directory.Domain.Aggregates.FilterLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListViewUrlTypeConfiguration : IEntityTypeConfiguration<FilterListViewUrl>
{
    public virtual void Configure(EntityTypeBuilder<FilterListViewUrl> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

        builder.ToTable($"{nr.RewriteName(nameof(Queries.Entities.FilterListViewUrl))}s");
        builder.Property<long>(nameof(Queries.Entities.FilterListViewUrl.Id));
    }
}
