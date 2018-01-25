using System;

namespace FilterLists.Services.Models.Seed
{
    public class FilterListSeedDto
    {
        public int Id { get; set; }
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
        public string SubmissionUrl { get; set; }
        public int? SyntaxId { get; set; }
        public string ViewUrl { get; set; }
    }
}