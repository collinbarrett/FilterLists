using System;
using System.Collections.Generic;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Software : IHaveSurrogateKey
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri HomeUrl { get; set; }
        public Uri DownloadUrl { get; set; }
        public bool SupportsAbpUrlScheme { get; set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}