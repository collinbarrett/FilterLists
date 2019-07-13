using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Features.Urls.Models
{
    [UsedImplicitly]
    public class LicenseUrls
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri DescriptionUrl { get; [UsedImplicitly] private set; }
    }
}