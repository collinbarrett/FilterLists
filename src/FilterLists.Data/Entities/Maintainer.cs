using System.Collections.Generic;
using FilterLists.Data.Entities.Junctions;

namespace FilterLists.Data.Entities
{
    public class Maintainer : BaseEntity
    {
        public string EmailAddress { get; set; }
        public ICollection<FilterListMaintainer> FilterListMaintainers { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
    }
}