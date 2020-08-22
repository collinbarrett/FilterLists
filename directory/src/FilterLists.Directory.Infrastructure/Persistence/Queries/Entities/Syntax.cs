using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Syntax : IHaveSurrogateKey
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? Url { get; private set; }
        public ICollection<FilterListSyntax> FilterListSyntaxes { get; private set; } = new HashSet<FilterListSyntax>();
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; private set; } = new HashSet<SoftwareSyntax>();
    }
}