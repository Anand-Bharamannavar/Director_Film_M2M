using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Service
{
    public interface IFilmService
    {
        bool AddFilmService(Film film);

        bool DeleteFilmService(string filmName);
        List<Film> GetFilmsService();
    }
}
