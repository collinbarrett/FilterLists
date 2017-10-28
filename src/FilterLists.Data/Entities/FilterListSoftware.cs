namespace FilterLists.Data.Entities
{
    public class FilterListSoftware : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }

        public int SoftwareId { get; set; }
        public Software Software { get; set; }
    }
}