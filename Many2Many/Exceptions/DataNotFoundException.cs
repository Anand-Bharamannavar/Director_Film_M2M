using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Many2Many.Exceptions
{

    [Serializable]
    internal class DataNotFoundException : Exception
    {
        public DataNotFoundException()

        {
        }
        public DataNotFoundException(string message) : base(message)
        {
        }
        public DataNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DataNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        /* public DataNotFoundException(Exception exception) : base(String.Format("data can't Access ,Exception is :" + exception))
         {
         }*/
    }
}
