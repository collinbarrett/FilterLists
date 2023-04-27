using FilterLists.Api.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Persistence.Entities;

public record FilterList
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public int LicenseId { get; init; }
    public License License { get; init; } = null!;
    public IEnumerable<Syntax> Syntaxes { get; init; } = new HashSet<Syntax>();
    public IEnumerable<Language> Languages { get; init; } = new HashSet<Language>();
    public IEnumerable<Tag> Tags { get; init; } = new HashSet<Tag>();
    public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new HashSet<FilterListViewUrl>();
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IEnumerable<Maintainer> Maintainers { get; init; } = new HashSet<Maintainer>();
    public IEnumerable<FilterList> UpstreamFilterLists { get; init; } = new HashSet<FilterList>();
    public IEnumerable<FilterList> ForkFilterLists { get; init; } = new HashSet<FilterList>();
    public IEnumerable<FilterList> IncludedInFilterLists { get; init; } = new HashSet<FilterList>();
    public IEnumerable<FilterList> IncludesFilterLists { get; init; } = new HashSet<FilterList>();
    public IEnumerable<FilterList> DependencyFilterLists { get; init; } = new HashSet<FilterList>();
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