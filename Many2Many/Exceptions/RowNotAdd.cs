using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Many2Many.Exceptions
{

    [Serializable]
    internal class RowNotAdd : Exception
    {
        public RowNotAdd()
        {
        }

        public RowNotAdd(string message) : base(message)
        {
        }

        public RowNotAdd(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RowNotAdd(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
    }
