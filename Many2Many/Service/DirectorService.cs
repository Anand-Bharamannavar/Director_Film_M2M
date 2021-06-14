using Director_Film.API.Repository;
using Many2Many.Exceptions;
using Many2Many.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Director_Film.API.Service
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirector _service = null;

        public DirectorService(IDirector service)
        {
            _service = service;
        }
        public bool AddDirectorService(Director director)
        {
            try
            {
                return _service.AddDirector(director);
            }
            catch (RowNotAdd exception)
            {
                throw new RowNotAdd("Cant add Director", exception);
            }
        }

        public Director GetDirectorService(string name)
        {
            try
            {
                return _service.GetDirector(name);
            }
            catch (DataNotFoundException exception)
            {
                throw new DataNotFoundException("Cannot GetDirector", exception);
            }
        }

        public bool UpdateDirectorService(Director director)
        {
            try
            {
                return _service.UpdateDirector(director);
            }
            catch (RowNotUpdate exception)
            {
                throw new RowNotUpdate("Cannot Update Director", exception);
            }
        }
    }
}
