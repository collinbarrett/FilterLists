namespace FilterLists.Data.Entities
{
    public class Scrape : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }
    }
}