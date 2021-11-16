using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record Maintainer
{
    public int Id { get; private init; }
    public string Name { get; private init; } = null!;
    public Uri? Url { get; private init; }
    public string? EmailAddress { get; private init; }
    public string? TwitterHandle { get; private init; }
    public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
}

internal class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
{
    public virtual void Configure(EntityTypeBuilder<Maintainer> builder)
    {
        builder.HasDataJsonFile<Maintainer>();
    }
}
