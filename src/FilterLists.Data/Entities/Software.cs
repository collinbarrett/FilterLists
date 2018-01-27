using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Software
    {
        public int Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime ModifiedDateUtc { get; set; }

        public string DownloadUrl { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }

        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}