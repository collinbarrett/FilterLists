using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;
using JetBrains.Annotations;

namespace FilterLists.Data.Entities
{
    [UsedImplicitly]
    public class FilterList : BaseEntity
    {
        public bool CantSnapshot { get; set; }
        public string ChatUrl { get; set; }
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
        public uint? LicenseId { get; set; }
        public License License { get; set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; set; }
        public ICollection<Merge> MergeFilterLists { get; set; }
        public ICollection<Merge> UpstreamMergeFilterLists { get; set; }
        public string Name { get; set; }
        public string PolicyUrl { get; set; }
        public DateTime? PublishedDate { get; set; }
        public ICollection<Snapshot> Snapshots { get; set; }
        public string SubmissionUrl { get; set; }
        public uint? SyntaxId { get; set; }
        public Syntax Syntax { get; set; }
        public string ViewUrl { get; set; }
    }
}