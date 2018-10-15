using System;

namespace FilterLists.Services.Wayback.Models
{
    public class SnapshotMetaDto
    {
        public string RawUrl { get; set; }
        public DateTime TimestampUtc { get; set; }
    }
}