using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlFlow
{
    [Serializable]
    public class InvalidACcountValueException : Exception
    {
        public InvalidACcountValueException() { }
        public InvalidACcountValueException(string message) : base(message) { }
        public InvalidACcountValueException(string message, Exception inner) : base(message, inner) { }
        protected InvalidACcountValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
