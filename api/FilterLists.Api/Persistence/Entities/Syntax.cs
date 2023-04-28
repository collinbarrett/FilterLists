using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The named set of rules that govern how <see cref="FilterList" />s are parsed
/// </summary>
public record Syntax
{
    /// <summary>
    ///     The unique identifier of the Syntax
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name of the Syntax
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The brief English description of the Syntax
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The homepage URL of the Syntax
    /// </summary>
    public Uri? Url { get; init; }

    /// <summary>
    ///     The <see cref="FilterList" />s which implement the Syntax
    /// </summary>
    public IEnumerable<FilterList> FilterLists { get; init; } = new HashSet<FilterList>();

    /// <summary>
    ///     The <see cref="Software" /> which support the Syntax
    /// </summary>
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