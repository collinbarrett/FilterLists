using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Api.Contracts.Models
{
    public class ListDetailsVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? LicenseId { get; set; }
        public IEnumerable<int>? SyntaxIds { get; set; }
        public IEnumerable<string>? Iso6391s { get; set; }
        public IEnumerable<int>? TagIds { get; set; }
        public IEnumerable<ViewUrlVm>? ViewUrls { get; set; }
        public Uri? HomeUrl { get; set; }
        public Uri? OnionUrl { get; set; }
        public Uri? PolicyUrl { get; set; }
        public Uri? SubmissionUrl { get; set; }
        public Uri? IssuesUrl { get; set; }
        public Uri? ForumUrl { get; set; }
        public Uri? ChatUrl { get; set; }
        public string? EmailAddress { get; set; }
        public Uri? DonateUrl { get; set; }
        public IEnumerable<int>? MaintainerIds { get; set; }
        public IEnumerable<int>? UpstreamFilterListIds { get; set; }
        public IEnumerable<int>? ForkFilterListIds { get; set; }
        public IEnumerable<int>? IncludedInFilterListIds { get; set; }
        public IEnumerable<int>? IncludesFilterListIds { get; set; }
        public IEnumerable<int>? DependencyFilterListIds { get; set; }
        public IEnumerable<int>? DependentFilterListIds { get; set; }

        public class ViewUrlVm
        {
            public short SegmentNumber { get; set; }
            public short Primariness { get; set; }
            public Uri Url { get; set; } = null!;
        }
    }
}
