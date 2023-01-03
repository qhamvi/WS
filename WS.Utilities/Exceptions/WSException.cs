using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Utilities.Exceptions
{
    public class WSException : Exception
    {
        public WSException()
        {
        }

        public WSException(string message) : base(message)
        {
        }

        public WSException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
