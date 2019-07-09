using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.List
{
    [UsedImplicitly]
    public class ListUrl
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri ViewUrl { get; [UsedImplicitly] private set; }
    }
}