using FilterLists.Data;
using Microsoft.Extensions.Configuration;

namespace FilterLists.Services.Snapshot
{
    public class BatchSizeService : Service
    {
        private readonly int batchSize = 1000;

        public BatchSizeService(FilterListsDbContext dbContext, IConfiguration config) : base(dbContext)
        {
            var configBatchSize = config.GetSection("Snapshots").GetValue<int>("BatchSize");
            batchSize = configBatchSize > 0 ? configBatchSize : batchSize;
        }

        public int GetBatchSize() => batchSize;
    }
}