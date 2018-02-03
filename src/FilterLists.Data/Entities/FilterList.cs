using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class FilterList : BaseEntity
    {
        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public string DonateUrl { get; set; }
        public string EmailAddress { get; set; }
        public ICollection<Fork> ForkFilterLists { get; set; }
        public ICollection<Fork> UpstreamForkFilterLists { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public ICollection<FilterListLanguage> FilterListLanguages { get; set; }
        public int? LicenseId { get; set; }
        public License License { get; set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; set; }
        public ICollection<Merge> MergeFilterLists { get; set; }
        public ICollection<Merge> UpstreamMergeFilterLists { get; set; }
        public string Name { get; set; }
        public string PolicyUrl { get; set; }
        public ICollection<FilterListRule> FilterListRules { get; set; }
        public ICollection<Scrape> Scrapes { get; set; }
        public string SubmissionUrl { get; set; }
        public int? SyntaxId { get; set; }
        public Syntax Syntax { get; set; }
        public string ViewUrl { get; set; }
    }
}