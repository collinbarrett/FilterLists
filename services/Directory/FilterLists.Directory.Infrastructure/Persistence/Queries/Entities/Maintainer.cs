using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record Maintainer
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public Uri? Url { get; init; }
    public string? EmailAddress { get; init; }
    public string? TwitterHandle { get; init; }
    public IEnumerable<FilterListMaintainer> FilterListMaintainers { get; init; } = new List<FilterListMaintainer>();
}

internal sealed class MaintainerTypeConfiguration : IEntityTypeConfiguration<Maintainer>
{
    public void Configure(EntityTypeBuilder<Maintainer> builder)
    {
        builder.Property(m => m.Name)
            .HasMaxLength(64);
        builder.HasIndex(m => m.Name)
            .IsUnique();
        builder.Property(m => m.Url)
            .HasMaxLength(512);
        builder.Property(m => m.EmailAddress)
            .HasMaxLength(256);
        builder.Property(m => m.TwitterHandle)
            .HasMaxLength(32);
        builder.HasDataJsonFile<Maintainer>();
    }
}