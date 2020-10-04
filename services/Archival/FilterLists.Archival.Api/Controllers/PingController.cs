using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Archival.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class PingController : ControllerBase
    {
        /// <summary>
        /// A sample endpoint.
        /// </summary>
        /// <returns>Pong.</returns>
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
#pragma warning disable CA1822 // Mark members as static
        public ActionResult<string> Ping()
#pragma warning restore CA1822 // Mark members as static
        {
            return "pong";
        }
    }
}
