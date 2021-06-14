using Many2Many.Context;
using Many2Many.Exceptions;
using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Repository
{
    public class FilmDirectorRepository : IFilmDirector
    {
        private readonly DirectorFilm _context = null;

        public FilmDirectorRepository(DirectorFilm context)
        {
            _context = context;
        }


        public bool AddFilmDirector(FilmDirector filmDirector)
        {
            try
            {
                _context.FilmDirectors.Add(filmDirector);
                int result = _context.SaveChanges();
                if (result == 0)
                {
                    return false;
                }

                return true;

            }
            catch (RowNotAdd ex)
            {
                throw new RowNotAdd("Cannot Added");
            }
        }

        public List<FilmDirector> GetDirectorsByFilmName(string filmName)
        {
            //  List<String> directorNames = new List<string>();
            try
            {

                List<FilmDirector> filmDirectors = _context.FilmDirectors.ToList();
                List<FilmDirector> filmDirectors1 = new List<FilmDirector>();
                foreach (var item in filmDirectors)
                {
                    if (item.FilmName == filmName)
                    {
                        // directorNames.Add(item.DirectorName);
                        item.Director = _context.Directors.Find(item.DirectorName);
                        item.Director.FilmDirectors = null;
                        filmDirectors1.Add(item);

                    }
                }
                return filmDirectors1;
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("data not Found");
            }
        }

        public List<FilmDirector> GetFilmsByDirectorName(string directorName)
        {
            try
            {
                // List<String> filmNames = new List<string>();
                List<FilmDirector> filmDirectors1 = new List<FilmDirector>();
                List<FilmDirector> filmDirectors = _context.FilmDirectors.ToList();
                foreach (var item in filmDirectors)
                {
                    if (item.DirectorName == directorName)
                    {
                        // filmNames.Add(item.FilmName);
                        item.Film = _context.Films.Find(item.FilmName);
                        item.Film.FilmDirectors = null;
                        filmDirectors1.Add(item);
                    }
                }
                //return filmNames;
                return filmDirectors1;
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("data not Found");
            }
        }


        public List<FilmDirector> GetFilmDirector()
        {
            try
            {
                return _context.FilmDirectors.ToList();
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("data not Found");
            }
        }

    }
}
