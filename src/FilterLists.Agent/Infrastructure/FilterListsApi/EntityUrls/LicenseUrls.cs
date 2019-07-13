using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.FilterListsApi.EntityUrls
{
    [UsedImplicitly]
    public class LicenseUrls
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri DescriptionUrl { get; [UsedImplicitly] private set; }
    }
}