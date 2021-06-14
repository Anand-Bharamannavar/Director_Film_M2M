using Director_Film.API.Repository;
using Many2Many.Exceptions;
using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Service
{
    public class DirectorFilmService : IDirectorFilmService
    {
         private readonly IFilmDirector _service = null;

        public DirectorFilmService(IFilmDirector service)
        {
            _service = service;
        }
        public bool AddFilmDirectorService(FilmDirector filmDirector)
        {
            try
            {
                return _service.AddFilmDirector(filmDirector);
            }
            catch (RowNotAdd exception)
            {
                throw new RowNotAdd("Cannot Add Director", exception);
            }
        }

        public List<FilmDirector> GetDirectorsByFilmNameService(string filmName)
        {
            try
            {
                return _service.GetDirectorsByFilmName(filmName);
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("Data Not Found", exception);
            }
        }

        public List<FilmDirector> GetFilmDirectorService()
        {
            try
            {
                return _service.GetFilmDirector();
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("Data Not Found", exception);
            }
        }

        public List<FilmDirector> GetFilmsByDirectorNameService(string directorName)
        {
            try
            {
                return _service.GetFilmsByDirectorName(directorName);
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("Data Not Found", exception);
            }
        }
    }
}
