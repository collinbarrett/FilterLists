using System;
using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class ViewUrlMirror : IHaveSurrogateKey
    {
        public  ushort Id { get; set; }
        public FilterList FilterList { get; set; }
        public Uri Url { get; set; }
    }
}