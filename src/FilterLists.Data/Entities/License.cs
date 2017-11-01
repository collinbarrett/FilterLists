using System.Collections.Generic;

namespace FilterLists.Data.Entities
{
    public class License : BaseEntity
    {
        public string DescriptionUrl { get; set; }
        public ICollection<FilterList> FilterLists { get; set; }
        public string Name { get; set; }
        public bool PermissiveAdaptation { get; set; }
        public bool PermissiveCommercial { get; set; }
    }
}