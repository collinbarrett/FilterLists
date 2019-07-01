using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class SoftwareUrls : IEntityUrls
    {
        public Uri DownloadUrl { get; set; }
        public Uri HomeUrl { get; set; }
    }
}