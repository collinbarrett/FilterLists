using System;
using FilterLists.Agent.Core.Entities;
using JetBrains.Annotations;

namespace FilterLists.Agent.Features.Urls.Models
{
    [UsedImplicitly]
    public class SoftwareUrls : IEntityUrls
    {
        public Uri DownloadUrl { get; set; }
        public Uri HomeUrl { get; set; }
    }
}