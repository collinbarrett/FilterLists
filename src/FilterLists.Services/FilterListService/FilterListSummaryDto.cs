using System.Collections.Generic;

namespace FilterLists.Services.FilterListService
{
    public class FilterListSummaryDto
    {
        public int Id { get; set; }
        public IEnumerable<string> Languages { get; set; }
        public string Name { get; set; }
        public string ViewUrl { get; set; }
    }
}