using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterList : AggregateRoot
{
    public int Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public int LicenseId { get; init; }
    public License License { get; } = null!;
    public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
    public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
    public IReadOnlyCollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
    public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; } = new HashSet<FilterListViewUrl>();
    public Uri? HomeUrl { get; init; }
    public Uri? OnionUrl { get; init; }
    public Uri? PolicyUrl { get; init; }
    public Uri? SubmissionUrl { get; init; }
    public Uri? IssuesUrl { get; init; }
    public Uri? ForumUrl { get; init; }
    public Uri? ChatUrl { get; init; }
    public string? EmailAddress { get; init; }
    public Uri? DonateUrl { get; init; }
    public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
    public IReadOnlyCollection<Fork> UpstreamFilterLists { get; } = new HashSet<Fork>();
    public IReadOnlyCollection<Fork> ForkFilterLists { get; } = new HashSet<Fork>();
    public IReadOnlyCollection<Merge> IncludedInFilterLists { get; } = new HashSet<Merge>();
    public IReadOnlyCollection<Merge> IncludesFilterLists { get; } = new HashSet<Merge>();
    public IReadOnlyCollection<Dependent> DependencyFilterLists { get; } = new HashSet<Dependent>();
    public IReadOnlyCollection<Dependent> DependentFilterLists { get; } = new HashSet<Dependent>();
}

internal class FilterListTypeConfiguration : AggregateRootTypeConfiguration<FilterList>
{
    public override void Configure(EntityTypeBuilder<FilterList> builder)
    {
        builder.HasIndex(f => f.Name)
            .IsUnique();
        builder.Property(f => f.LicenseId)
            .HasDefaultValue(5);
        builder.HasOne(f => f.License)
            .WithMany(l => l.FilterLists)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasDataJsonFile<FilterList>();
        base.Configure(builder);
    }
}
