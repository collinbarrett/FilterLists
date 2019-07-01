using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class SyntaxUrls : IEntityUrls
    {
        public int Id { get; set; }
        public string DefinitionUrl { get; set; }
    }
}