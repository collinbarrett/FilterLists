using System;

namespace FilterLists.Data.Models.Contracts
{
    public interface IFilterList
    {
        string Author { get; set; }
        string Description { get; set; }
        string DescriptionSourceUrl { get; set; }
        string DonateUrl { get; set; }
        string Email { get; set; }
        string ForumUrl { get; set; }
        string HomeUrl { get; set; }
        string IssuesUrl { get; set; }
        string Name { get; set; }
        string ViewUrl { get; set; }
        long Id { get; set; }
        DateTime CreatedDateUtc { get; set; }
        DateTime? ModifiedDateUtc { get; set; }
    }
}