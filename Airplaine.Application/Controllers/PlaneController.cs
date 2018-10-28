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

        [HttpPost("create")]
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

        [HttpPut("update")]
        public IActionResult update([FromBody] Plane plane)
        {
            try
            {
                service.Put<PlaneValidators>(plane);

                return new ObjectResult(plane);
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

        [HttpGet("get")]
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

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id){
            try{
                service.Delete(id);
                return NoContent();
            }catch(Exception ex){
                return BadRequest(ex);
            }
        }

    }
}