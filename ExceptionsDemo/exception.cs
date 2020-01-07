using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class ExtraCrewException : Exception
    {
        public ExtraCrewException()
        {
            
        }

        public ExtraCrewException(string message) : base(message)
        {
            
        }

        public ExtraCrewException(string message, System.Exception inner): base(message, inner)
        {
            
        }

        protected ExtraCrewException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context): base(info, context)
        {
            
        }
    }
}
