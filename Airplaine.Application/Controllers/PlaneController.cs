using System;
using Aiplane.Service.Service;
using Airplane.Domain.Entities;
using Airplane.Service;
using Microsoft.AspNetCore.Mvc;

namespace Airplane.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/plane")]
    public class PlaneController : Controller
    {
        private BaseService<Plane> service = new BaseService<Plane>();

        [HttpPost("Create")]
        public IActionResult Post([FromBody] Plane plane)
        {
            try
            {
                service.Post<PlaneValidators>(plane);

                return new ObjectResult(plane.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("Get")]
        public IActionResult GetAll()
        {

            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}