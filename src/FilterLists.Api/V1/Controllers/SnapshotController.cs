using System.Threading.Tasks;
using FilterLists.Services.SnapshotService;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class SnapshotController : BaseController
    {
        private readonly SnapshotService snapshotService;

        public SnapshotController(SnapshotService snapshotService)
        {
            this.snapshotService = snapshotService;
        }

        [HttpPost]
        //TODO: convert API endpoint to server-side scheduled job
        public async Task<IActionResult> Index()
        {
#if DEBUG
            await snapshotService.CaptureSnapshotsAsync(1);
            return Ok();
#else
            return StatusCode(403);
#endif
        }
    }
}