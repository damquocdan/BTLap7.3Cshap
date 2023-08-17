using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLap7._3Cshap
{
    public class InvalidMarkException : Exception
    {
        public InvalidMarkException() : base("Invalid mark value provided.")
        {
        }

        public InvalidMarkException(string message) : base(message)
        {
        }

        public InvalidMarkException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

}
