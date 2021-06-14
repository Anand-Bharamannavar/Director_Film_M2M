using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Many2Many.Exceptions
{
    [Serializable]
    internal class RowNotUpdate:Exception
    {

        
        public RowNotUpdate()
        {
        }
        public RowNotUpdate(string message) : base(message)
        {
        }
        public RowNotUpdate(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RowNotUpdate(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
        /*public RowNotUpdate(Exception exception) : base(String.Format(" can't updated,Exception is : " + exception))
        {
        }*/
    }
}
