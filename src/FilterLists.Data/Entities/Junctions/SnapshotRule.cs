using System;

namespace FilterLists.Data.Entities.Junctions
{
    public class SnapshotRule : BaseJunction
    {
        public DateTime ModifiedDateUtc { get; set; }
        public int AddedBySnapshotId { get; set; }
        public Snapshot AddedBySnapshot { get; set; }
        public int? RemovedBySnapshotId { get; set; }
        public Snapshot RemovedBySnapshot { get; set; }
        public int RuleId { get; set; }
        public Rule Rule { get; set; }
    }
}