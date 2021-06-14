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
    public class FilmController : ControllerBase
    {
        private IFilmService _filmService;

        public FilmController(IFilmService filmservice)
        {
            _filmService = filmservice;
        }


        [HttpPost]
        public IActionResult Post(Film film)
        {
            try
            {
                _filmService.AddFilmService(film);
                return Created("Film Added", film);

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
                return Ok(_filmService.GetFilmsService());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [HttpDelete("{filmName}")]
        public IActionResult Delete(string filmName)
        {
            try
            {
                return Ok(_filmService.DeleteFilmService(filmName));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
