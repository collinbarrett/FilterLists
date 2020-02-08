using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class FilterListDto
    {
        public int Id { get; set; }
        public string ChatUrl { get; set; }
        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public string DonateUrl { get; set; }
        public string EmailAddress { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public List<int> LanguageIds { get; set; }
        public int? LicenseId { get; set; }
        public List<int> MaintainerIds { get; set; }
        public string Name { get; set; }
        public string PolicyUrl { get; set; }
        public DateTime? PublishedDate { get; set; }
        //public int? RuleCount { get; set; }
        public string SubmissionUrl { get; set; }
        public int? SyntaxId { get; set; }
        public List<int> TagIds { get; set; }
        //public DateTime? UpdatedDate { get; set; }
        public string ViewUrl { get; set; }
        public List<string> ViewUrlMirrors { get; set; }
    }
}