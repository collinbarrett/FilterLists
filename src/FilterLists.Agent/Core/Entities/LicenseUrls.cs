using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Entities
{
    [UsedImplicitly]
    public class LicenseUrls : IEntityUrls
    {
        public Uri DescriptionUrl { get; set; }
    }
}