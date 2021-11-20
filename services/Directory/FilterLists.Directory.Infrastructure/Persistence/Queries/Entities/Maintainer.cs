using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Maintainer : AggregateRoot
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public Uri? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
    public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; init; } = new HashSet<FilterListMaintainer>();
}

internal class MaintainerTypeConfiguration : AggregateRootTypeConfiguration<Maintainer>
{
    public override void Configure(EntityTypeBuilder<Maintainer> builder)
    {
        builder.HasIndex(m => m.Name)
            .IsUnique();
        builder.HasDataJsonFileAggregate<Maintainer>();
        base.Configure(builder);
    }
}
