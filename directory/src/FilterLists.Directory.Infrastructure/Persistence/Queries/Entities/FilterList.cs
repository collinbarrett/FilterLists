using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class FilterList : ISurrogateKey
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Uri ViewUrl { get; set; }
        public Uri HomeUrl { get; set; }
        public Uri OnionUrl { get; set; }
        public Uri PolicyUrl { get; set; }
        public Uri SubmissionUrl { get; set; }
        public Uri IssuesUrl { get; set; }
        public Uri ForumUrl { get; set; }
        public Uri ChatUrl { get; set; }
        public string EmailAddress { get; set; }
        public Uri DonateUrl { get; set; }
    }
}