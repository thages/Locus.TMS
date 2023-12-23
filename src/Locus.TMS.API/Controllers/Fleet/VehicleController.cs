using Locus.TMS.Application.Commands.Fleet;
using Locus.TMS.Application.Fleet.Queries;
using Locus.TMS.Domain.DataTransferObjects.Fleet;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Locus.TMS.API.Controllers.Fleet
{
    [Route("api/v1/[controller]")]
    //[Authorize]
    [ApiController]
    public class VehicleController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [Route("vehicles")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VehicleItem>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<VehicleItem>>> Get(CancellationToken token)
        {
            var response = await _mediator.Send(new ListAllVehiclesQuery(),token);
            return Ok(response); 
        }

        [HttpPost]
        [ProducesResponseType(typeof(VehicleItem), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody] CreateVehicleCommand command, CancellationToken token)
        {
            var response = await _mediator.Send(command, token);

            if (response is null)
                return BadRequest();
            
            return Ok(response);
        }
        
        
        //// GET api/<VehicleController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// PUT api/<VehicleController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<VehicleController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
