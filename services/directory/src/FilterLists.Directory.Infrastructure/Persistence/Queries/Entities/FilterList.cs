using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public int? LicenseId { get; private set; }
        public License? License { get; private set; }
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; private set; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; private set; } = new HashSet<FilterListLanguage>();
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; private set; } = new HashSet<FilterListTag>();
        public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; private set; } = new HashSet<FilterListViewUrl>();
        public Uri? HomeUrl { get; private set; }
        public Uri? OnionUrl { get; private set; }
        public Uri? PolicyUrl { get; private set; }
        public Uri? SubmissionUrl { get; private set; }
        public Uri? IssuesUrl { get; private set; }
        public Uri? ForumUrl { get; private set; }
        public Uri? ChatUrl { get; private set; }
        public string? EmailAddress { get; private set; }
        public Uri? DonateUrl { get; private set; }
        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; private set; } = new HashSet<FilterListMaintainer>();
        public IReadOnlyCollection<Fork> UpstreamFilterLists { get; private set; } = new HashSet<Fork>();
        public IReadOnlyCollection<Fork> ForkFilterLists { get; private set; } = new HashSet<Fork>();
        public IReadOnlyCollection<Merge> IncludedInFilterLists { get; private set; } = new HashSet<Merge>();
        public IReadOnlyCollection<Merge> IncludesFilterLists { get; private set; } = new HashSet<Merge>();
        public IReadOnlyCollection<Dependent> DependencyFilterLists { get; private set; } = new HashSet<Dependent>();
        public IReadOnlyCollection<Dependent> DependentFilterLists { get; private set; } = new HashSet<Dependent>();
    }

    internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
    {
        public virtual void Configure(EntityTypeBuilder<FilterList> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));
            builder.OwnsMany(fl => fl.ViewUrls,
                    o =>
                    {
                        o.ToTable(nameof(FilterListViewUrl) + "s");
                        const string id = "Id";
                        o.Property<int>(id);
                        o.HasKey(id);
                        const string filterListId = nameof(FilterList) + id;
                        o.Property<int>(filterListId);
                        o.Property(u => u.SegmentNumber).HasDefaultValue(1);
                        o.Property(u => u.Primariness).HasDefaultValue(1);
                        o.HasIndex(
                                filterListId,
                                nameof(FilterListViewUrl.SegmentNumber),
                                nameof(FilterListViewUrl.Primariness))
                            .IsUnique();
                    })
                .HasDataJsonFile<FilterListViewUrl>();
            builder.HasDataJsonFile<FilterList>();
        }
    }
}