using System.Collections.Generic;

namespace FilterLists.Directory.Api.Contracts.Models
{
    public class ListVm
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public int? LicenseId { get; private set; }
        public IEnumerable<int>? SyntaxIds { get; private set; }
        public IEnumerable<string>? Iso6391s { get; private set; }
        public IEnumerable<int>? TagIds { get; private set; }
        public IEnumerable<int>? MaintainerIds { get; private set; }
    }
}
