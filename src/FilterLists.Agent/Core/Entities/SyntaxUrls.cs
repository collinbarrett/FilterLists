using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class SyntaxUrls : IEntityUrls
    {
        public Uri DefinitionUrl { get; set; }
    }
}