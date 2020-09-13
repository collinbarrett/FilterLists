using System.Collections.Generic;

namespace FilterLists.SharedKernel.Apis.Contracts.Directory
{
    public class ListVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int? LicenseId { get; set; }
        public IEnumerable<int>? SyntaxIds { get; set; }
        public IEnumerable<string>? Iso6391s { get; set; }
        public IEnumerable<int>? TagIds { get; set; }
        public IEnumerable<int>? MaintainerIds { get; set; }
    }
}
