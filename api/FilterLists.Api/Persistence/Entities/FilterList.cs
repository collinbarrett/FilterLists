using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

/// <summary>
///     The list of filter rules to block advertisements, trackers, and other unwanted content
/// </summary>
public record FilterList
{
    /// <summary>
    ///     The unique identifier of the FilterList
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    ///     The unique name in title case of the FilterList
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    ///     The brief English description of the FilterList
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    ///     The unique identifier of the <see cref="License" /> under which the FilterList is licensed
    /// </summary>
    public int LicenseId { get; init; }

    /// <summary>
    ///     The <see cref="License" /> under which the FilterList is licensed
    /// </summary>
    public License License { get; init; } = null!;

    /// <summary>
    ///     The <see cref="Syntax" />es which the FilterList implements
    /// </summary>
    public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();

    /// <summary>
    ///     The <see cref="Language" />s of the websites targeted by the FilterList
    /// </summary>
    public IEnumerable<Language> Languages { get; init; } = new HashSet<Language>();

    /// <summary>
    ///     The <see cref="Tag" />s applied to the FilterList
    /// </summary>
    public IEnumerable<Tag> Tags { get; init; } = new HashSet<Tag>();

    /// <summary>
    ///     The URLs at which the FilterList can be viewed or downloaded
    /// </summary>
    public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();

    /// <summary>
    ///     The homepage URL of the FilterList
    /// </summary>
    public Uri? HomeUrl { get; init; }

    /// <summary>
    ///     The Onion (TOR) URL of the FilterList
    /// </summary>
    public Uri? OnionUrl { get; init; }

    /// <summary>
    ///     The policy URL of guidelines and rule types of the FilterList
    /// </summary>
    public Uri? PolicyUrl { get; init; }

    /// <summary>
    ///     The rule submission or contact form URL of the FilterList
    /// </summary>
    public Uri? SubmissionUrl { get; init; }

    /// <summary>
    ///     The GitHub Issues URL of the FilterList
    /// </summary>
    public Uri? IssuesUrl { get; init; }

    /// <summary>
    ///     The forum URL of the FilterList
    /// </summary>
    public Uri? ForumUrl { get; init; }

    /// <summary>
    ///     The chat room URL of the FilterList
    /// </summary>
    public Uri? ChatUrl { get; init; }

    /// <summary>
    ///     The email address of the FilterList
    /// </summary>
    public string? EmailAddress { get; init; }

    /// <summary>
    ///     The donate URL of the FilterList
    /// </summary>
    public Uri? DonateUrl { get; init; }

    /// <summary>
    ///     The <see cref="Maintainer" />s of the FilterList
    /// </summary>
    public IEnumerable<Maintainer> Maintainers { get; init; } = new HashSet<Maintainer>();

    /// <summary>
    ///     The <see cref="FilterList" />s from which the FilterList was forked
    /// </summary>
    public IEnumerable<FilterList> UpstreamFilterLists { get; init; } = new HashSet<FilterList>();

    /// <summary>
    ///     The <see cref="FilterList" />s forked from the FilterList
    /// </summary>
    public IEnumerable<FilterList> ForkFilterLists { get; init; } = new HashSet<FilterList>();

    /// <summary>
    ///     The <see cref="FilterList" />s in which the FilterList is included
    /// </summary>
    public IEnumerable<FilterList> IncludedInFilterLists { get; init; } = new HashSet<FilterList>();

    /// <summary>
    ///     The <see cref="FilterList" />s the FilterList includes
    /// </summary>
    public IEnumerable<FilterList> IncludesFilterLists { get; init; } = new HashSet<FilterList>();

    /// <summary>
    ///     The <see cref="FilterList" />s the FilterList depends upon
    /// </summary>
    public IEnumerable<FilterList> DependencyFilterLists { get; init; } = new HashSet<FilterList>();

    /// <summary>
    ///     The <see cref="FilterList" />s dependent upon the FilterList
    /// </summary>
    public IEnumerable<FilterList> DependentFilterLists { get; init; } = new HashSet<FilterList>();
}

internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public virtual void Configure(EntityTypeBuilder<FilterList> builder)
    {
        builder.HasIndex(f => f.Name)
            .IsUnique();
        builder.Property(f => f.LicenseId)
            .HasDefaultValue(5);
        builder.HasOne(f => f.License)
            .WithMany(l => l.FilterLists)
            .OnDelete(DeleteBehavior.Restrict);
        builder
            .HasMany(f => f.Syntaxes)
            .WithMany(s => s.FilterLists)
            .UsingEntity<FilterListSyntax>(j => j.HasDataJsonFile<FilterListSyntax>());
        builder
            .HasMany(f => f.Languages)
            .WithMany(l => l.FilterLists)
            .UsingEntity<FilterListLanguage>(j => j.HasDataJsonFile<FilterListLanguage>());
        builder
            .HasMany(f => f.Tags)
            .WithMany(t => t.FilterLists)
            .UsingEntity<FilterListTag>(j => j.HasDataJsonFile<FilterListTag>());
        builder.OwnsMany(
            f => f.ViewUrls,
            b =>
            {
                b.Property(u => u.SegmentNumber)
                    .HasDefaultValue(1);
                b.Property(u => u.Primariness)
                    .HasDefaultValue(1);
                b.HasIndex(u => new { u.FilterListId, u.SegmentNumber, u.Primariness })
                    .IsUnique();
                b.HasDataJsonFile<FilterListViewUrl>();
            });
        builder
            .HasMany(f => f.Maintainers)
            .WithMany(m => m.FilterLists)
            .UsingEntity<FilterListMaintainer>(j => j.HasDataJsonFile<FilterListMaintainer>());
        builder
            .HasMany(f => f.UpstreamFilterLists)
            .WithMany(f => f.ForkFilterLists)
            .UsingEntity<Fork>(
                r => r.HasOne<FilterList>().WithMany().HasForeignKey(f => f.UpstreamFilterListId),
                l => l.HasOne<FilterList>().WithMany().HasForeignKey(f => f.ForkFilterListId),
                j => { j.HasDataJsonFile<Fork>(); });
        builder
            .HasMany(f => f.IncludedInFilterLists)
            .WithMany(f => f.IncludesFilterLists)
            .UsingEntity<Merge>(
                r => r.HasOne<FilterList>().WithMany().HasForeignKey(m => m.IncludedInFilterListId),
                l => l.HasOne<FilterList>().WithMany().HasForeignKey(m => m.IncludesFilterListId),
                j => { j.HasDataJsonFile<Merge>(); });
        builder
            .HasMany(f => f.DependencyFilterLists)
            .WithMany(f => f.DependentFilterLists)
            .UsingEntity<Dependent>(
                r => r.HasOne<FilterList>().WithMany().HasForeignKey(d => d.DependencyFilterListId),
                l => l.HasOne<FilterList>().WithMany().HasForeignKey(d => d.DependentFilterListId),
                j => { j.HasDataJsonFile<Dependent>(); });
        builder.HasDataJsonFile<FilterList>();
    }
}