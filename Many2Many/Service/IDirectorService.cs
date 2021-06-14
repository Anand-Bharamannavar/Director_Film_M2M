using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Service
{
    public interface IDirectorService
    {
        bool AddDirectorService(Director director);

        bool UpdateDirectorService(Director director);

        Director GetDirectorService(string name);
    }
}
