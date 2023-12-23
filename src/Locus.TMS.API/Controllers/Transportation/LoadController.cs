using Locus.TMS.Application.Transportation.Queries;
using Locus.TMS.Domain.Transportation.DataTransferObjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Locus.TMS.API.Controllers.Transportation
{
    [Route("api/v1/[controller]")]
    //[Authorize]
    [ApiController]
    public class LoadController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [Route("loads")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<LoadItem>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LoadItem>>> Get(CancellationToken token)
        {
            var response = await _mediator.Send(new ListAllLoadsQuery(), token);
            return Ok(response);
        }
    }
}
