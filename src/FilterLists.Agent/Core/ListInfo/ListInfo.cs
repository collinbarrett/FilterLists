using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.ListInfo
{
    [UsedImplicitly]
    public class ListInfo
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri ViewUrl { get; [UsedImplicitly] private set; }
    }
}