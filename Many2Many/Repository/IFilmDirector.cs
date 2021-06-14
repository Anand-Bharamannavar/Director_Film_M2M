using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Repository
{
    public interface IFilmDirector
    {
        bool AddFilmDirector(FilmDirector filmDirector);

        List<FilmDirector> GetFilmDirector();

        List<FilmDirector> GetDirectorsByFilmName(string filmName);

        List<FilmDirector> GetFilmsByDirectorName(string directorName);
    }
}
