using FilterLists.Services.Services;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class MaintainersController : EntityController
    {
        public MaintainersController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }
    }
}