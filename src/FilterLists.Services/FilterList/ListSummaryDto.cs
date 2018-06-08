using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList
{
    [UsedImplicitly]
    public class ListSummaryDto
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public IEnumerable<ListLanguagesDto> Languages { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ViewUrl { get; set; }
    }
}