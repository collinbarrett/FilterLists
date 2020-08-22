using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Syntax : IHaveSurrogateKey
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Url { get; set; }
        public ICollection<FilterListSyntax> FilterListSyntaxes { get; set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}