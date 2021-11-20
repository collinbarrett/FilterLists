using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FilterList = FilterLists.Directory.Domain.Aggregates.FilterLists.FilterList;

namespace FilterLists.Directory.Infrastructure.Persistence.Commands.EntityTypeConfigurations;

internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public virtual void Configure(EntityTypeBuilder<FilterList> builder)
    {
        builder.Property<int>(nameof(Queries.Entities.FilterList.Id));
        builder.HasMany(c => c.Changes)
            .WithOne()
            .HasForeignKey(nameof(Change.FilterListId));
        builder.Navigation(f => f.Changes)
            .AutoInclude();
        builder.Navigation(f => f.ViewUrls)
            .AutoInclude();
    }
}
