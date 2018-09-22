using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class ListDetailsDto
    {
        public int Id { get; set; }
        public string ChatUrl { get; set; }
        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public string DonateUrl { get; set; }
        public string EmailAddress { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public IEnumerable<string> Languages { get; set; }
        public ListLicenseDto License { get; set; }
        public IEnumerable<ListMaintainerDto> Maintainers { get; set; }
        public string Name { get; set; }
        public string PolicyUrl { get; set; }
        public DateTime? PublishedDate { get; set; }
        public int RuleCount { get; set; }
        public string SubmissionUrl { get; set; }
        public ListSyntaxDto Syntax { get; set; }
        public IEnumerable<ListTagDto> Tags { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ViewUrl { get; set; }
        public string ViewUrlMirror1 { get; set; }
        public string ViewUrlMirror2 { get; set; }
    }
}