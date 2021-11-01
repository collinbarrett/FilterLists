using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList
    {
        // TODO: use private setters on all entity/vm props after System.Text.Json support
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? LicenseId { get; set; }
        public License? License { get; set; }
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
        public IReadOnlyCollection<FilterListViewUrl> ViewUrls { get; } = new HashSet<FilterListViewUrl>();
        public Uri? HomeUrl { get; set; }
        public Uri? OnionUrl { get; set; }
        public Uri? PolicyUrl { get; set; }
        public Uri? SubmissionUrl { get; set; }
        public Uri? IssuesUrl { get; set; }
        public Uri? ForumUrl { get; set; }
        public Uri? ChatUrl { get; set; }
        public string? EmailAddress { get; set; }
        public Uri? DonateUrl { get; set; }

        public IReadOnlyCollection<FilterListMaintainer> FilterListMaintainers { get; } =
            new HashSet<FilterListMaintainer>();

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
