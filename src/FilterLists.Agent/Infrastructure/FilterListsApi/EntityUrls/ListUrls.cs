using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.FilterListsApi.EntityUrls
{
    [UsedImplicitly]
    public class ListUrls
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri ChatUrl { get; [UsedImplicitly] private set; }
        public Uri DescriptionSourceUrl { get; [UsedImplicitly] private set; }
        public Uri DonateUrl { get; [UsedImplicitly] private set; }
        public Uri ForumUrl { get; [UsedImplicitly] private set; }
        public Uri HomeUrl { get; [UsedImplicitly] private set; }
        public Uri IssuesUrl { get; [UsedImplicitly] private set; }
        public Uri PolicyUrl { get; [UsedImplicitly] private set; }
        public Uri SubmissionUrl { get; [UsedImplicitly] private set; }
        public Uri ViewUrl { get; [UsedImplicitly] private set; }
        public Uri ViewUrlMirror1 { get; [UsedImplicitly] private set; }
        public Uri ViewUrlMirror2 { get; [UsedImplicitly] private set; }
    }
}