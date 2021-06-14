using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Repository
{
    public interface IDirector
    {

        bool AddDirector(Director director);

        bool UpdateDirector(Director director);

        Director GetDirector(string name);

    }
}
