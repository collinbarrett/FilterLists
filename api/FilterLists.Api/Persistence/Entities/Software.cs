using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The application, browser extension, or other utility that consumes <see cref="FilterList" />s
/// </summary>
public record Software
{
    /// <summary>
    ///     The unique identifier of the Software
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name of the Software
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The brief English description of the Software
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The homepage URL of the Software
    /// </summary>
    public Uri? HomeUrl { get; init; }

    /// <summary>
    ///     The download URL of the Software
    /// </summary>
    public Uri? DownloadUrl { get; init; }

    /// <summary>
    ///     If the Software supports the "abp:" URI scheme
    /// </summary>
    public bool SupportsAbpUrlScheme { get; init; }

    /// <summary>
    ///     The <see cref="Syntax" />es which the Software supports
    /// </summary>
    public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
}

internal class SoftwareTypeConfiguration : IEntityTypeConfiguration<Software>
{
    public virtual void Configure(EntityTypeBuilder<Software> builder)
    {
        builder.HasIndex(s => s.Name)
            .IsUnique();
        builder.Property(s => s.SupportsAbpUrlScheme)
            .HasDefaultValue(false);
        builder
            .HasMany(s => s.Syntaxes)
            .WithMany(s => s.Software)
            .UsingEntity<SoftwareSyntax>(j => j.HasDataJsonFile<SoftwareSyntax>());
        builder.HasDataJsonFile<Software>();
    }
}