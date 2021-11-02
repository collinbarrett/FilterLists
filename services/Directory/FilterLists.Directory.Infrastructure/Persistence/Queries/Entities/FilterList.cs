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
        public License? License { get; }
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
        public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; } = new HashSet<FilterListViewUrl>();
        public Uri? HomeUrl { get; private set; }
        public Uri? OnionUrl { get; private set; }
        public Uri? PolicyUrl { get; private set; }
        public Uri? SubmissionUrl { get; private set; }
        public Uri? IssuesUrl { get; private set; }
        public Uri? ForumUrl { get; private set; }
        public Uri? ChatUrl { get; private set; }
        public string? EmailAddress { get; private set; }
        public Uri? DonateUrl { get; private set; }
        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
        public IReadOnlyCollection<Fork> UpstreamFilterLists { get; } = new HashSet<Fork>();
        public IReadOnlyCollection<Fork> ForkFilterLists { get; } = new HashSet<Fork>();
        public IReadOnlyCollection<Merge> IncludedInFilterLists { get; } = new HashSet<Merge>();
        public IReadOnlyCollection<Merge> IncludesFilterLists { get; } = new HashSet<Merge>();
        public IReadOnlyCollection<Dependent> DependencyFilterLists { get; } = new HashSet<Dependent>();
        public IReadOnlyCollection<Dependent> DependentFilterLists { get; } = new HashSet<Dependent>();
    }

    internal class FilterListTypeConfiguration : IEntityTypeConfiguration<FilterList>
    {
        public virtual void Configure(EntityTypeBuilder<FilterList> builder)
        {
            builder.HasDataJsonFile<FilterList>();
        }
    }
}
