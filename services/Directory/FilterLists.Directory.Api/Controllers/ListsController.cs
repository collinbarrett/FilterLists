using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using FilterLists.Directory.Application.Queries;
using FilterLists.SharedKernel.Apis.Contracts.Directory;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace FilterLists.Directory.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListsController : BaseController
    {
        private readonly IMediator _mediator;

        public ListsController(IMemoryCache cache, IMediator mediator) : base(cache)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetLists.ListVm>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return await CacheGetOrCreateAsync(() => _mediator.Send(new GetLists.Query(), cancellationToken));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ListDetailsVm), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetDetails(int id, CancellationToken cancellationToken)
        {
            return await CacheGetOrCreateAsync(() => _mediator.Send(new GetListDetails.Query(id), cancellationToken), id);
        }
    }
}