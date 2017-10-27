using System.Collections.Generic;

namespace FilterLists.Data.Entities
{
    public class Maintainer : BaseEntity
    {
        public string Email { get; set; }
        public List<FilterList> FilterLists { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string TwitterHandle { get; set; }
    }
}