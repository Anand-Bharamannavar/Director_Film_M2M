using Many2Many.Context;
using Many2Many.Model;
using Many2Many.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Repository
{
    public class FilmRepository : IFilm
    {
        private readonly DirectorFilm _context = null;

        public FilmRepository(DirectorFilm context)
        {
            _context = context;
        }
        public bool AddFilm(Film film)
        {
            try
            {
                _context.Films.Add(film);
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



        public List<Film> GetFilms()
        {
            try
            {
                List<Film> FilmList = _context.Films.ToList();
                return FilmList;
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("data not Found");
            }
        }

        public bool DeleteFilm(string filmName)
        {
            try
            {
                Film film = _context.Films.Find(filmName);
                List<FilmDirector> filmDirectors = _context.FilmDirectors.Where(m => m.FilmName == filmName).ToList();
                if (film == null)
                {
                    throw new InvalidNameException("Invalid Name!!");
                }
                _context.Films.Remove(film);

                foreach (var item in filmDirectors)
                {
                    _context.FilmDirectors.Remove(item);
                    // context.SaveChanges();

                }
                int result = _context.SaveChanges();
                if (result == 0)
                {
                    return false;
                }

                return true;

            }
            catch (InvalidNameException exception)
            {
                throw new InvalidNameException("Can't delete");
            }
        }

    }
}
