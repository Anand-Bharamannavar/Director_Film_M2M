using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Repository
{
    public interface IFilm
    {
        bool AddFilm(Film film);

        bool DeleteFilm(string filmName);
        List<Film> GetFilms();
    }
}
