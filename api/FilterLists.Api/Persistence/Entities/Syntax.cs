using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record Syntax
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public Uri? Url { get; init; }
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();
    public IEnumerable<Software> Software { get; init; } = new HashSet<Software>();
}

internal class SyntaxTypeConfiguration : IEntityTypeConfiguration<Syntax>
{
    public virtual void Configure(EntityTypeBuilder<Syntax> builder)
    {
        builder.HasIndex(s => s.Name).IsUnique();
        builder.HasDataJsonFile<Syntax>();
    }
}