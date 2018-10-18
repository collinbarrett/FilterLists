using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Snapshot : BaseEntity
    {
        public int FilterListId { get; set; }
        public FilterList FilterList { get; set; }
        public int? HttpStatusCode { get; set; }
        public byte[] Md5Checksum { get; set; }
        public ICollection<SnapshotRule> SnapshotRules { get; set; }
        public bool WasSuccessful { get; set; }
        public bool WasUpdated { get; set; }
        public DateTime? WaybackTimestamp { get; set; }
        public string WaybackUrl { get; set; }
    }
}