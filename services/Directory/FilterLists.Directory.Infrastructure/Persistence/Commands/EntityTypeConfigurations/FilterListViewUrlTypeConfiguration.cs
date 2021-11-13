using FilterLists.Directory.Domain.Aggregates.FilterLists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListViewUrlTypeConfiguration : IEntityTypeConfiguration<FilterListViewUrl>
{
    public virtual void Configure(EntityTypeBuilder<FilterListViewUrl> builder)
    {
        builder.ToTable(nameof(FilterListViewUrl) + "s");
        builder.Property<int>(nameof(Queries.Entities.FilterListViewUrl.Id));
    }
}
