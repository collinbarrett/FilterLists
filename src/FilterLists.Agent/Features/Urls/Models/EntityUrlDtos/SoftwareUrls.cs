using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Features.Urls.Models.EntityUrlDtos
{
    [UsedImplicitly]
    public class SoftwareUrls
    {
        public Uri DownloadUrl { get; set; }
        public Uri HomeUrl { get; set; }
    }
}