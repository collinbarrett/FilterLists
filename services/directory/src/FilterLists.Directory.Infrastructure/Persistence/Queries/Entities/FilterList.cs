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
        public IReadOnlyCollection<FilterListSegmentViewUrl> SegmentViewUrls { get; private set; } = new HashSet<FilterListSegmentViewUrl>();
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
            builder.OwnsMany(fl => fl.SegmentViewUrls,
                    o1 =>
                    {
                        o1.ToTable(nameof(FilterListSegmentViewUrl) + "s");
                        const string filterListId = nameof(FilterList) + "Id";
                        o1.HasKey(filterListId, nameof(FilterListSegmentViewUrl.Position));
                        o1.Property(u => u.Position).ValueGeneratedNever();
                        o1.OwnsMany(u => u.Mirrors,
                                o2 =>
                                {
                                    o2.ToTable(nameof(FilterListSegmentViewUrlMirror) + "s");
                                    const string segmentViewUrlFilterListId =
                                        nameof(FilterListSegmentViewUrlMirror.SegmentViewUrl) + filterListId;
                                    const string segmentViewUrlPosition =
                                        nameof(FilterListSegmentViewUrlMirror.SegmentViewUrl) +
                                        nameof(FilterListSegmentViewUrlMirror.Position);
                                    o2.Property<int>(segmentViewUrlFilterListId);
                                    o2.Property<int>(segmentViewUrlPosition);
                                    o2.Property(m => m.Position).ValueGeneratedNever();
                                    o2.HasKey(
                                        segmentViewUrlFilterListId,
                                        segmentViewUrlPosition,
                                        nameof(FilterListSegmentViewUrlMirror.Position));
                                })
                            .HasDataJsonFile<FilterListSegmentViewUrlMirror>();
                    })
                .HasDataJsonFile<FilterListSegmentViewUrl>();
            builder.HasDataJsonFile<FilterList>();
        }
    }
}