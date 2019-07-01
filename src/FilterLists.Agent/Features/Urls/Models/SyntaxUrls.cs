using System;
using FilterLists.Agent.Core.Entities;
using JetBrains.Annotations;

namespace FilterLists.Agent.Features.Urls.Models
{
    [UsedImplicitly]
    public class SyntaxUrls : IEntityUrls
    {
        public Uri DefinitionUrl { get; set; }
    }
}