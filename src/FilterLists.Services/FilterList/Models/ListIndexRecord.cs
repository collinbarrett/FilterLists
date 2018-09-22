using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace FilterLists.Services.FilterList.Models
{
    [UsedImplicitly]
    public class ListIndexRecord
    {
        public int Id { get; set; }
        public List<int> LanguageIds { get; set; }
        public List<int> MaintainerIds { get; set; }
        public string Name { get; set; }
        public int? RuleCount { get; set; }
        public int? SyntaxId { get; set; }
        public List<int> TagIds { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ViewUrl { get; set; }
        public List<string> ViewUrlMirrors { get; set; }
    }
}