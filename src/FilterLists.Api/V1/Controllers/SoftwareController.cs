using FilterLists.Services.Services;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Api.V1.Controllers
{
    public class SoftwareController : EntityController
    {
        public SoftwareController(IMemoryCache memoryCache, SeedService seedService) : base(memoryCache, seedService)
        {
        }
    }
}