using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software : IHaveSurrogateKey
    {
        public ushort Id { get; }
        public string Name { get; } = null!;
        public string? Description { get; }
        public Uri? HomeUrl { get; }
        public Uri? DownloadUrl { get; }
        public bool SupportsAbpUrlScheme { get; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; } = new HashSet<SoftwareSyntax>();
    }
}