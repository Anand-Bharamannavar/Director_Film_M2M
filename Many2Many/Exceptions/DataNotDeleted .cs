using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Many2Many.Exceptions
{
    [Serializable]
    internal class DataNotDeleted : Exception
    {
        public DataNotDeleted()
        {

        }
        public DataNotDeleted(string message) : base(message)
        {
        }
        public DataNotDeleted(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DataNotDeleted(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        /*public DataNotDeleted(Exception exception) : base(String.Format(" data can't Deleted,Exception is :" + exception))
        {
        }*/
    }
}
