using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList
    {
        public string Name { get; } = null!;
        public string? Description { get; private set; }
        public License? License { get; private set; }
        public ICollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
        public ICollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
        public ICollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
        public Uri ViewUrl { get; } = null!;
        public ICollection<ViewUrlPartial> ViewUrlPartials { get; } = new HashSet<ViewUrlPartial>();
        public ICollection<ViewUrlMirror> ViewUrlMirrors { get; } = new HashSet<ViewUrlMirror>();
        public Uri? HomeUrl { get; private set; }
        public Uri? OnionUrl { get; private set; }
        public Uri? PolicyUrl { get; private set; }
        public Uri? SubmissionUrl { get; private set; }
        public Uri? IssuesUrl { get; private set; }
        public Uri? ForumUrl { get; private set; }
        public Uri? ChatUrl { get; private set; }
        public string? EmailAddress { get; private set; }
        public Uri? DonateUrl { get; private set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
        public ICollection<Fork> UpstreamFilterLists { get; } = new HashSet<Fork>();
        public ICollection<Fork> ForkFilterLists { get; } = new HashSet<Fork>();
        public ICollection<Merge> IncludedInFilterLists { get; } = new HashSet<Merge>();
        public ICollection<Merge> IncludesFilterLists { get; } = new HashSet<Merge>();
        public ICollection<Dependent> DependencyFilterLists { get; } = new HashSet<Dependent>();
        public ICollection<Dependent> DependentFilterLists { get; } = new HashSet<Dependent>();
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