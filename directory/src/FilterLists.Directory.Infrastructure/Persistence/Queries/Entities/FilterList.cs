using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList : IHaveSurrogateKey
    {
        public ushort Id { get; }
        public string Name { get; } = null!;
        public string? Description { get; }
        public License? License { get; }
        public ICollection<FilterListSyntax> FilterListSyntaxes { get; } = new HashSet<FilterListSyntax>();
        public ICollection<FilterListLanguage> FilterListLanguages { get; } = new HashSet<FilterListLanguage>();
        public ICollection<FilterListTag> FilterListTags { get; } = new HashSet<FilterListTag>();
        public Uri ViewUrl { get; } = null!;
        public ICollection<ViewUrlPartial> ViewUrlPartials { get; } = new HashSet<ViewUrlPartial>();
        public ICollection<ViewUrlMirror> ViewUrlMirrors { get; } = new HashSet<ViewUrlMirror>();
        public Uri? HomeUrl { get; }
        public Uri? OnionUrl { get; }
        public Uri? PolicyUrl { get; }
        public Uri? SubmissionUrl { get; }
        public Uri? IssuesUrl { get; }
        public Uri? ForumUrl { get; }
        public Uri? ChatUrl { get; }
        public string? EmailAddress { get; }
        public Uri? DonateUrl { get; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; } = new HashSet<FilterListMaintainer>();
        public ICollection<Fork> UpstreamFilterLists { get; } = new HashSet<Fork>();
        public ICollection<Fork> ForkFilterLists { get; } = new HashSet<Fork>();
        public ICollection<Merge> IncludedInFilterLists { get; } = new HashSet<Merge>();
        public ICollection<Merge> IncludesFilterLists { get; } = new HashSet<Merge>();
        public ICollection<Dependent> DependencyFilterLists { get; } = new HashSet<Dependent>();
        public ICollection<Dependent> DependentFilterLists { get; } = new HashSet<Dependent>();
    }
}