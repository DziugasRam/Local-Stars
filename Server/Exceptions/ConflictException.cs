using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Exceptions
{
    public class ConflictException: Exception
    {
        public ConflictException() : base()
        {
        }

        public ConflictException(string message) : base(message)
        {
        }
    }
}
