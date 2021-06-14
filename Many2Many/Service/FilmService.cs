using Director_Film.API.Repository;
using Many2Many.Exceptions;
using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Service
{
    public class FilmService : IFilmService
    {
        private readonly IFilm _service = null;

        public FilmService(IFilm service)
        {
            _service = service;
        }

        public bool AddFilmService(Film film)
        {
            try
            {
                return _service.AddFilm(film);
            }
            catch (RowNotAdd exception)
            {
                throw new RowNotAdd("Cannot Add", exception);
            }
        }

        public bool DeleteFilmService(string filmName)
        {
            try
            {
                return _service.DeleteFilm(filmName);
            }
            catch (InvalidNameException exception)
            {
                throw new InvalidNameException("Data Not Found", exception);
            }
        }

        public List<Film> GetFilmsService()
        {
            try
            {
                return _service.GetFilms();
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("Data Not Found", exception);
            }
        }
    }
}
