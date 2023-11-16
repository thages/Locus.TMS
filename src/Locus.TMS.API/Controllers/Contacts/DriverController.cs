using Locus.TMS.Application.Contacts.Commands;
using Locus.TMS.Application.Contacts.Queries;
using Locus.TMS.Domain.Contacts.DataTransferObjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Locus.TMS.API.Controllers.Contacts
{
    [Route("api/v1/[controller]")]
    //[Authorize]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DriverController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("drivers")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<DriverItem>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<DriverItem>>> Get(CancellationToken token)
        {
            var response = await _mediator.Send(new ListAllDriversQuery(), token);
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(DriverItem), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateDriverCommand command, CancellationToken token)
        {
            var response = await _mediator.Send(command, token);

            if (response is null)
                return BadRequest();

            return Ok(response);
        }

    }
}
