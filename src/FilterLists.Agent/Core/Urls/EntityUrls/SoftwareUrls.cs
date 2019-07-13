using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Urls.EntityUrls
{
    [UsedImplicitly]
    public class SoftwareUrls
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri DownloadUrl { get; [UsedImplicitly] private set; }
        public Uri HomeUrl { get; [UsedImplicitly] private set; }
    }
}