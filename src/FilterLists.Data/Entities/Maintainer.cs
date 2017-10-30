using System.Collections.Generic;

namespace FilterLists.Data.Entities
{
    public class Maintainer : BaseEntity
    {
        public string EmailAddress { get; set; }
        public ICollection<FilterList> FilterLists { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
    }
}