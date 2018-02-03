using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Snapshot : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public int? HttpStatusCode { get; set; }
        public ICollection<SnapshotRule> SnapshotRules { get; set; }
    }
}