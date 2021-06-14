using Director_Film.API.Service;
using Many2Many.Context;
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
    public class FilmDirectorController : ControllerBase
    {
        private IDirectorFilmService _filmDirectorService;

        public FilmDirectorController(IDirectorFilmService filmDirectorService)
        {
            _filmDirectorService = filmDirectorService;
        }


        [HttpPost]
        public IActionResult Post(FilmDirector filmDirector)
        {
            try
            {
                _filmDirectorService.AddFilmDirectorService(filmDirector);
                return Created("FilmDirector Added", filmDirector);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_filmDirectorService.GetFilmDirectorService());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetDirectorsByFilmName/{filmName}")]
        public IActionResult GetDirectorByFilmName(string filmName)
        {
            try
            {
                return Ok(_filmDirectorService.GetDirectorsByFilmNameService(filmName));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetFilmNamesByDirector/{directorName}")]
        public IActionResult GetFilmNamesByDirector(string directorName)
        {
            try
            {
                return Ok(_filmDirectorService.GetFilmsByDirectorNameService(directorName));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



    }
}
