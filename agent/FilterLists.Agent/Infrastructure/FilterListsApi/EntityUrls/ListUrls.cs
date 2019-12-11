using System;

namespace FilterLists.Agent.Infrastructure.FilterListsApi.EntityUrls
{
    public class ListUrls
    {
        public int Id { get; private set; }
        public Uri ChatUrl { get; private set; }
        public Uri DescriptionSourceUrl { get; private set; }
        public Uri DonateUrl { get; private set; }
        public Uri ForumUrl { get; private set; }
        public Uri HomeUrl { get; private set; }
        public Uri IssuesUrl { get; private set; }
        public Uri PolicyUrl { get; private set; }
        public Uri SubmissionUrl { get; private set; }
        public Uri ViewUrl { get; private set; }
        public Uri ViewUrlMirror1 { get; private set; }
        public Uri ViewUrlMirror2 { get; private set; }
    }
}