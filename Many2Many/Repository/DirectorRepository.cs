using Many2Many.Context;
using Many2Many.Exceptions;
using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Repository
{
    public class DirectorRepository : IDirector
    {
        private readonly DirectorFilm _context = null;

        public DirectorRepository(DirectorFilm context)
        {
            _context = context;
        }


        public bool AddDirector(Director director)
        {
            try
            {
                _context.Directors.Add(director);
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

        public Director GetDirector(string name)
        {
            try
            {
                Director director = _context.Directors.Find(name);
                List<FilmDirector> filmDirectors = _context.FilmDirectors.ToList();
                foreach (var item in filmDirectors)
                {
                    if (item.DirectorName == name)
                    {
                        item.Director = null;
                        //    director.FilmDirectors.Add(item);
                    }
                }

                return director;
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("data not Found");
            }
        }



        public bool UpdateDirector(Director director)
        {
            try
            {
                _context.Directors.Update(director);
                int result = _context.SaveChanges();
                if (result == 0)
                {
                    return false;
                }

                return true;

            }
            catch (RowNotUpdate exception)
            {
                throw new RowNotUpdate("cannot Update");
            }
        }
    }
}
