using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Api.Contracts.Models
{
    public class ListDetailsVm
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public int? LicenseId { get; private set; }
        public IEnumerable<int>? SyntaxIds { get; private set; }
        public IEnumerable<string>? Iso6391s { get; private set; }
        public IEnumerable<int>? TagIds { get; private set; }
        public IEnumerable<ViewUrlVm>? ViewUrls { get; private set; }
        public Uri? HomeUrl { get; private set; }
        public Uri? OnionUrl { get; private set; }
        public Uri? PolicyUrl { get; private set; }
        public Uri? SubmissionUrl { get; private set; }
        public Uri? IssuesUrl { get; private set; }
        public Uri? ForumUrl { get; private set; }
        public Uri? ChatUrl { get; private set; }
        public string? EmailAddress { get; private set; }
        public Uri? DonateUrl { get; private set; }
        public IEnumerable<int>? MaintainerIds { get; private set; }
        public IEnumerable<int>? UpstreamFilterListIds { get; private set; }
        public IEnumerable<int>? ForkFilterListIds { get; private set; }
        public IEnumerable<int>? IncludedInFilterListIds { get; private set; }
        public IEnumerable<int>? IncludesFilterListIds { get; private set; }
        public IEnumerable<int>? DependencyFilterListIds { get; private set; }
        public IEnumerable<int>? DependentFilterListIds { get; private set; }

        public class ViewUrlVm
        {
            public short SegmentNumber { get; private set; }
            public short Primariness { get; private set; }
            public Uri Url { get; private set; } = null!;
        }
    }
}
