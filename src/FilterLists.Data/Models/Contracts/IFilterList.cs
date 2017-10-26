namespace FilterLists.Data.Models.Contracts
{
    public interface IFilterList
    {
        string Description { get; set; }
        string DescriptionSourceUrl { get; set; }
        string DonateUrl { get; set; }
        string Email { get; set; }
        string ForumUrl { get; set; }
        string HomeUrl { get; set; }
        string IssuesUrl { get; set; }
        string Name { get; set; }
        string ViewUrl { get; set; }
    }
}