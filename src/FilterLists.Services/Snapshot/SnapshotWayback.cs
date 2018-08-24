using System.Threading.Tasks;
using FilterLists.Data;
using FilterLists.Services.Snapshot.Models;
using FilterLists.Services.Wayback;
using JetBrains.Annotations;

namespace FilterLists.Services.Snapshot
{
    public class SnapshotWayback : Snapshot
    {
        public SnapshotWayback()
        {
        }

        [UsedImplicitly]
        public SnapshotWayback(BatchSizeService batchSizeService, FilterListsDbContext dbContext,
            FilterListViewUrlDto list, string uaString)
            : base(batchSizeService, dbContext, list, uaString)
        {
        }

        public override async Task TrySaveAsync()
        {
            await UpdateWaybackData();
            await TrySaveAsyncBase();
        }

        private async Task UpdateWaybackData()
        {
            var snapshotMeta = await WaybackService.GetMostRecentSnapshotMeta(ListUrl);
            if (snapshotMeta != null)
            {
                ListUrl = snapshotMeta.UrlRaw;
                SnapEntity.WaybackTimestamp = snapshotMeta.TimestampUtc;
            }
            else
            {
                ListUrl = null;
            }
        }
    }
}