using System.Collections.Generic;

namespace FilterLists.Services.FilterList
{
    public class ListSummaryDto
    {
        public int Id { get; set; }
        public IEnumerable<ListLanguagesDto> Languages { get; set; }
        public string Name { get; set; }
        public string ViewUrl { get; set; }
    }

    public class ListLanguagesDto
    {
        public string Name { get; set; }
        public string Iso6391 { get; set; }
    }
}