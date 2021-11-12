using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterListMaintainer
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; } = null!;
    public int MaintainerId { get; init; }
    public Maintainer Maintainer { get; } = null!;
}

internal class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
{
    public virtual void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
    {
        builder.ToTable(nameof(FilterListMaintainer) + "s");
        builder.HasKey(flm => new { flm.FilterListId, flm.MaintainerId });
        builder.HasDataJsonFile<FilterListMaintainer>();
    }
}
