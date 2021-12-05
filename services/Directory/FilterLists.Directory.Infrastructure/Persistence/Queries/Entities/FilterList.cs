using System.Globalization;
using EFCore.NamingConventions.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities;

public record FilterList : EntityRequiringApproval
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
    public long LicenseId { get; init; }
    public License License { get; init; } = default!;
    public IEnumerable<FilterListSyntax> FilterListSyntaxes { get; init; } = new HashSet<FilterListSyntax>();
    public IEnumerable<FilterListLanguage> FilterListLanguages { get; init; } = new HashSet<FilterListLanguage>();
    public IEnumerable<FilterListTag> FilterListTags { get; init; } = new HashSet<FilterListTag>();
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
    public IEnumerable<FilterListMaintainer> FilterListMaintainers { get; init; } = new HashSet<FilterListMaintainer>();
    public IEnumerable<Fork> UpstreamFilterLists { get; init; } = new HashSet<Fork>();
    public IEnumerable<Fork> ForkFilterLists { get; init; } = new HashSet<Fork>();
    public IEnumerable<Merge> IncludedInFilterLists { get; init; } = new HashSet<Merge>();
    public IEnumerable<Merge> IncludesFilterLists { get; init; } = new HashSet<Merge>();
    public IEnumerable<Dependent> DependencyFilterLists { get; init; } = new HashSet<Dependent>();
    public IEnumerable<Dependent> DependentFilterLists { get; init; } = new HashSet<Dependent>();
    public IEnumerable<Change> Changes { get; init; } = new HashSet<Change>();
}

internal class FilterListTypeConfiguration : EntityRequiringApprovalTypeConfiguration<FilterList>
{
    public override void Configure(EntityTypeBuilder<FilterList> builder)
    {
        // TODO: register and resolve INameRewriter
        var nr = new SnakeCaseNameRewriter(CultureInfo.InvariantCulture);

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
                b.ToTable($"{nr.RewriteName(nameof(FilterListViewUrl))}s");
                b.Property(u => u.Id)
                    .UseHiLo($"EntityFrameworkHiLoSequence-{nameof(FilterListViewUrl)}");
                b.Property(u => u.SegmentNumber)
                    .HasDefaultValue(1);
                b.Property(u => u.Primariness)
                    .HasDefaultValue(1);
                b.HasIndex(u => new { u.FilterListId, u.SegmentNumber, u.Primariness })
                    .IsUnique();
                b.HasDataJsonFile<FilterListViewUrl>();
            });
        builder.HasDataJsonFileEntityRequiringApproval<FilterList>();
        base.Configure(builder);
    }
}
