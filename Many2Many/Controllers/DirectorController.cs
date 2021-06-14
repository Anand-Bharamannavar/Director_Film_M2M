using Director_Film.API.Service;
using Many2Many.Model;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Many2Many.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }


        [HttpPost]
        public IActionResult Post(Director director)
        {
            try
            {
                _directorService.AddDirectorService(director);
                return Created("Director Added", director);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPut]
        public IActionResult Put(Director director)
        {
            try
            {
                _directorService.UpdateDirectorService(director);
                return Created("Updated Succesfully", director);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet("GetDirector/{name}")]
        public IActionResult GetDirector(string name)
        {
            try
            {
                Director director = _directorService.GetDirectorService(name);
                if (director != null)
                {
                    return Ok(director);
                }
                return NotFound("Director Not Present");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


    }
}
