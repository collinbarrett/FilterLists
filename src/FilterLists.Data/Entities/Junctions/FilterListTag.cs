namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListTag : BaseJunctionEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}