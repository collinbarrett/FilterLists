using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software : IHaveSurrogateKey
    {
        public ushort Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? HomeUrl { get; private set; }
        public Uri? DownloadUrl { get; private set; }
        public bool SupportsAbpUrlScheme { get; private set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; private set; } = new HashSet<SoftwareSyntax>();
    }
}