namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListTag : BaseJunctionEntity
    {
        public uint FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public uint TagId { get; set; }
        public Tag Tag { get; set; }
    }
}