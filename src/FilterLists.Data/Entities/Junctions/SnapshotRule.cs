using System;

namespace FilterLists.Data.Entities.Junctions
{
    public class SnapshotRule : BaseJunctionEntity
    {
        public DateTime ModifiedDateUtc { get; set; }
        public uint AddedBySnapshotId { get; set; }
        public Snapshot AddedBySnapshot { get; set; }
        public uint? RemovedBySnapshotId { get; set; }
        public Snapshot RemovedBySnapshot { get; set; }
        public uint RuleId { get; set; }
        public Rule Rule { get; set; }
    }
}