using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Service
{
    public interface IDirectorFilmService
    {
        bool AddFilmDirectorService(FilmDirector filmDirector);

        List<FilmDirector> GetFilmDirectorService();

        List<FilmDirector> GetDirectorsByFilmNameService(string filmName);

        List<FilmDirector> GetFilmsByDirectorNameService(string directorName);
    }
}
