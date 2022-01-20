using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test.WPF.Exceptions
{
    internal class UserNotFound : Exception
    {
        public UserNotFound()
        {
        }

        public UserNotFound(string message) : base(message)
        {
        }

        public UserNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
