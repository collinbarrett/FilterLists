using FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Contracts;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    public class Tag : ISurrogateKey
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}