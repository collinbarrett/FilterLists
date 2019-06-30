using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class ListInfo
    {
        public int Id { get; private set; }
        public Uri ViewUrl { get; private set; }
    }
}