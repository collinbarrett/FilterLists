using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Features.Urls.Models
{
    [UsedImplicitly]
    public class SoftwareUrls
    {
        public Uri DownloadUrl { get; set; }
        public Uri HomeUrl { get; set; }
    }
}