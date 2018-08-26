using FilterLists.Data;

namespace FilterLists.Services.Snapshot
{
    public class BatchSizeService : Service
    {
        private const int DefaultBatchSize = 5000;

        public BatchSizeService(FilterListsDbContext dbContext) : base(dbContext)
        {
        }

        public static int GetBatchSize() => DefaultBatchSize;
    }
}