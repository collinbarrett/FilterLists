using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList
    {
        // TODO: use private setters on all entity props after System.Text.Json supports seeding in net5.0
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int LicenseId { get; set; }
        public License License { get; set; } = null!;
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; private set; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; private set; } = new HashSet<FilterListLanguage>();
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; private set; } = new HashSet<FilterListTag>();
        public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; private set; } = new HashSet<FilterListViewUrl>();
        public Uri? HomeUrl { get; set; }
        public Uri? OnionUrl { get; set; }
        public Uri? PolicyUrl { get; set; }
        public Uri? SubmissionUrl { get; set; }
        public Uri? IssuesUrl { get; set; }
        public Uri? ForumUrl { get; set; }
        public Uri? ChatUrl { get; set; }
        public string? EmailAddress { get; set; }
        public Uri? DonateUrl { get; set; }
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
            builder.HasDataJsonFile<FilterList>();
            builder.Property(fl => fl.LicenseId).HasDefaultValue(5);
        }
    }
}