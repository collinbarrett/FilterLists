using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Queries.Entities;

internal record FilterListMaintainer
{
    public int FilterListId { get; init; }
    public FilterList FilterList { get; init; } = default!;
    public int MaintainerId { get; init; }
    public Maintainer Maintainer { get; init; } = default!;
}

internal class FilterListMaintainerTypeConfiguration : IEntityTypeConfiguration<FilterListMaintainer>
{
    public virtual void Configure(EntityTypeBuilder<FilterListMaintainer> builder)
    {
        builder.HasKey(flm => new { flm.FilterListId, flm.MaintainerId });
        builder.HasDataJsonFile<FilterListMaintainer>();
    }
}