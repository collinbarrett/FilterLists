namespace FilterLists.Data.Entities.Junctions
{
    public class FilterListMaintainer : BaseJunctionEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public int MaintainerId { get; set; }
        public Maintainer Maintainer { get; set; }
    }
}