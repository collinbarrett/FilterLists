using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList : IHaveSurrogateKey
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public License License { get; set; }
        public ICollection<FilterListSyntax> FilterListSyntaxes { get; set; }
        public ICollection<FilterListLanguage> FilterListLanguages { get; set; }
        public ICollection<FilterListTag> FilterListTags { get; set; }
        public Uri ViewUrl { get; set; }
        public ICollection<ViewUrlPartial> ViewUrlPartials { get; set; }
        public ICollection<ViewUrlMirror> ViewUrlMirrors { get; set; }
        public Uri HomeUrl { get; set; }
        public Uri OnionUrl { get; set; }
        public Uri PolicyUrl { get; set; }
        public Uri SubmissionUrl { get; set; }
        public Uri IssuesUrl { get; set; }
        public Uri ForumUrl { get; set; }
        public Uri ChatUrl { get; set; }
        public string EmailAddress { get; set; }
        public Uri DonateUrl { get; set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; set; }
        public ICollection<Fork> UpstreamFilterLists { get; set; }
        public ICollection<Fork> ForkFilterLists { get; set; }
        public ICollection<Merge> IncludedInFilterLists { get; set; }
        public ICollection<Merge> IncludesFilterLists { get; set; }
        public ICollection<Dependent> DependencyFilterLists { get; set; }
        public ICollection<Dependent> DependentFilterLists { get; set; }
    }
}