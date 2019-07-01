using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class MaintainerUrls : IEntityUrls
    {
        public Uri HomeUrl { get; set; }
    }
}