using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList
    {
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public License? License { get; private set; }
        public IReadOnlyCollection<FilterListSyntax> FilterListSyntaxes { get; private set; } = new HashSet<FilterListSyntax>();
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; private set; } = new HashSet<FilterListLanguage>();
        public IReadOnlyCollection<FilterListTag> FilterListTags { get; private set; } = new HashSet<FilterListTag>();
        public Uri ViewUrl { get; private set; } = null!;
        public IReadOnlyCollection<ViewUrlPartial> ViewUrlPartials { get; private set; } = new HashSet<ViewUrlPartial>();
        public IReadOnlyCollection<ViewUrlMirror> ViewUrlMirrors { get; private set; } = new HashSet<ViewUrlMirror>();
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

    internal class FilterListTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : FilterList
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            const string filterListId = "Id";
            builder.Property<int>(filterListId);
            builder.HasKey(filterListId);
        }
    }
}