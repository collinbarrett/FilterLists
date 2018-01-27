using System;
using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Maintainer
    {
        public int Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime ModifiedDateUtc { get; set; }

        public string EmailAddress { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }

        public ICollection<FilterListMaintainer> FilterListMaintainers { get; set; }
    }
}