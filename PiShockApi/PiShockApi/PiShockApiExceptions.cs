using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiShockApi
{
    public class PiShockApiException : Exception
    {
        public PiShockApiException() { }

        public PiShockApiException(string message) : base(message) { }

        public PiShockApiException(string message, Exception innerException) : base(message, innerException) { }
    }
}
