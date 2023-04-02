using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Api.Entities;

public record FilterList
{
    public int Id { get; private init; }
    public string Name { get; private init; } = default!;
    public string? Description { get; private init; }
    public int LicenseId { get; private init; }
    public License License { get; private init; } = default!;
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; private init; } = new HashSet<FilterListSyntax>();

    public IEnumerable<FilterListLanguage> FilterListLanguages { get; private init; } =
        new HashSet<FilterListLanguage>();

    public IEnumerable<FilterListTag> FilterListTags { get; private init; } = new HashSet<FilterListTag>();
    public IEnumerable<FilterListViewUrl> ViewUrls { get; private init; } = new HashSet<FilterListViewUrl>();
    public Uri? HomeUrl { get; private init; }
    public Uri? OnionUrl { get; private init; }
    public Uri? PolicyUrl { get; private init; }
    public Uri? SubmissionUrl { get; private init; }
    public Uri? IssuesUrl { get; private init; }
    public Uri? ForumUrl { get; private init; }
    public Uri? ChatUrl { get; private init; }
    public string? EmailAddress { get; private init; }
    public Uri? DonateUrl { get; private init; }

    public IEnumerable<FilterListMaintainer> FilterListMaintainers { get; private init; } =
        new HashSet<FilterListMaintainer>();

    public IEnumerable<Fork> UpstreamFilterLists { get; private init; } = new HashSet<Fork>();
    public IEnumerable<Fork> ForkFilterLists { get; private init; } = new HashSet<Fork>();
    public IEnumerable<Merge> IncludedInFilterLists { get; private init; } = new HashSet<Merge>();
    public IEnumerable<Merge> IncludesFilterLists { get; private init; } = new HashSet<Merge>();
    public IEnumerable<Dependent> DependencyFilterLists { get; private init; } = new HashSet<Dependent>();
    public IEnumerable<Dependent> DependentFilterLists { get; private init; } = new HashSet<Dependent>();
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
        builder.HasDataJsonFile<FilterList>();
    }
}