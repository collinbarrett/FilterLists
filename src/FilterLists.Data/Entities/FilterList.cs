using System.Collections.Generic;

namespace FilterLists.Data.Entities
{
    public class FilterList : BaseEntity
    {
        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public string DonateUrl { get; set; }
        public string EmailAddress { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public List<Language> Languages { get; set; }
        public int MaintainerId { get; set; }
        public string Name { get; set; }
        public string ViewUrl { get; set; }
    }
}