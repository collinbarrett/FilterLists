using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class ListSummaryDto
    {
        public int Id { get; set; }
        public IEnumerable<ListLanguagesDto> Languages { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> SoftwareIds { get; set; }
        public IEnumerable<ListTagDto> Tags { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}