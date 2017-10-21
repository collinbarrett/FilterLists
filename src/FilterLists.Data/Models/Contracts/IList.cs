using System;

namespace FilterLists.Data.Models.Contracts
{
    public interface IList
    {
        string Name { get; set; }
        string ViewUrl { get; set; }
        string HomeUrl { get; set; }
        string Description { get; set; }
        string DescriptionSourceUrl { get; set; }
        string Author { get; set; }
        string ForumUrl { get; set; }
        string IssuesUrl { get; set; }
        string Email { get; set; }
        string DonateUrl { get; set; }
        long Id { get; set; }
        DateTime AddedDateUtc { get; set; }
        DateTime? ModifiedDateUtc { get; set; }
    }
}