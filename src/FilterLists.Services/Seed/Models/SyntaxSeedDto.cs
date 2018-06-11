using JetBrains.Annotations;

namespace FilterLists.Services.Seed.Models
{
    [UsedImplicitly]
    public class SyntaxSeedDto
    {
        public uint Id { get; set; }
        public string DefinitionUrl { get; set; }
        public string Name { get; set; }
    }
}