using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public sealed record FilterList
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public int LicenseId { get; init; }
    public License License { get; init; } = null!;
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; init; } = new List<FilterListSyntax>();
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new List<FilterListLanguage>();
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new List<FilterListTag>();
    public IEnumerable<FilterListViewUrl> ViewUrls { get; init; } = new List<FilterListViewUrl>();
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IEnumerable<FilterListMaintainer> FilterListMaintainers { get; init; } = new List<FilterListMaintainer>();
    public IEnumerable<Fork> UpstreamFilterLists { get; init; } = new List<Fork>();
    public IEnumerable<Fork> ForkFilterLists { get; init; } = new List<Fork>();
    public IEnumerable<Merge> IncludedInFilterLists { get; init; } = new List<Merge>();
    public IEnumerable<Merge> IncludesFilterLists { get; init; } = new List<Merge>();
    public IEnumerable<Dependent> DependencyFilterLists { get; init; } = new List<Dependent>();
    public IEnumerable<Dependent> DependentFilterLists { get; init; } = new List<Dependent>();
}

internal sealed class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
{
    public void Configure(EntityTypeBuilder<FilterList> builder)
    {
        builder.Property(f => f.Name)
            .HasMaxLength(256);
        builder.HasIndex(f => f.Name)
            .IsUnique();
        builder.Property(f => f.LicenseId)
            .HasDefaultValue(5);
        builder.HasOne(f => f.License)
            .WithMany(l => l.FilterLists)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(f => f.HomeUrl)
            .HasMaxLength(512);
        builder.Property(f => f.OnionUrl)
            .HasMaxLength(512);
        builder.Property(f => f.PolicyUrl)
            .HasMaxLength(512);
        builder.Property(f => f.SubmissionUrl)
            .HasMaxLength(512);
        builder.Property(f => f.IssuesUrl)
            .HasMaxLength(512);
        builder.Property(f => f.ForumUrl)
            .HasMaxLength(512);
        builder.Property(f => f.ChatUrl)
            .HasMaxLength(512);
        builder.Property(f => f.EmailAddress)
            .HasMaxLength(256);
        builder.Property(f => f.DonateUrl)
            .HasMaxLength(512);
        builder.OwnsMany(
            f => f.ViewUrls,
            b =>
            {
                b.Property(u => u.SegmentNumber)
                    .HasDefaultValue(1);
                b.Property(u => u.Primariness)
                    .HasDefaultValue(1);
                b.Property(u => u.Url)
                    .HasMaxLength(512);
                b.HasIndex(u => new { u.FilterListId, u.SegmentNumber, u.Primariness })
                    .IsUnique();
                b.HasDataJsonFile<FilterListViewUrl>();
            });
        builder.HasDataJsonFile<FilterList>();
    }
}