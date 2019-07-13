using System;

namespace FilterLists.Agent.Infrastructure.FilterListsApi.EntityUrls
{
    public class SoftwareUrls
    {
        public int Id { get; private set; }
        public Uri DownloadUrl { get; private set; }
        public Uri HomeUrl { get; private set; }
    }
}