using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class FilterList
    {
        public int Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime ModifiedDateUtc { get; set; }

        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public string DonateUrl { get; set; }
        public string EmailAddress { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public int? LicenseId { get; set; }
        public string Name { get; set; }
        public DateTime? ScrapedDateUtc { get; set; }
        public string SubmissionUrl { get; set; }
        public int? SyntaxId { get; set; }
        public DateTime? UpdatedDateUtc { get; set; }
        public string ViewUrl { get; set; }

        public ICollection<FilterListLanguage> FilterListLanguages { get; set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; set; }
        public ICollection<FilterListRule> FilterListRules { get; set; }
    }
}