using System;
using System.Collections.Generic;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public Uri? HomeUrl { get; private set; }
        public Uri? DownloadUrl { get; private set; }
        public bool SupportsAbpUrlScheme { get; private set; }
        public IReadOnlyCollection<SoftwareSyntax> SoftwareSyntaxes { get; private set; } = new HashSet<SoftwareSyntax>();
    }
}