using Locus.TMS.Application.Commands.Fleet;
using Locus.TMS.Application.Fleet.Queries;
using Locus.TMS.Domain.Fleet.DataTransferObjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Locus.TMS.API.Controllers.Fleet
{
    [Route("api/v1/[controller]")]
    //[Authorize]
    [ApiController]
    public class VehicleController(IMediator mediator) : ControllerBase
    {
        [Route("vehicles")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VehicleItem>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<VehicleItem>>> Get(CancellationToken token)
        {
            var response = await mediator.Send(new ListAllVehiclesQuery(),token);
            return Ok(response); 
        }

        [HttpPost]
        [ProducesResponseType(typeof(VehicleItem), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateVehicleCommand command, CancellationToken token)
        {
            var response = await mediator.Send(command, token);

            if (response is null)
                return BadRequest();
            
            return Ok(response);
        }

        [HttpGet("fleet")]
        [ProducesResponseType(typeof(IEnumerable<FleetItem>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FleetItem>>> GetFleet(CancellationToken token)
        {
            var response = await mediator.Send(new ListFleetQuery(), token);
            return Ok(response);
        }
    }
}
