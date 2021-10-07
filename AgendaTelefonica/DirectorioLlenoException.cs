using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    [Serializable]
    public class DirectorioLlenoException : Exception
    {
        public DirectorioLlenoException() : base() { }
        public DirectorioLlenoException(string message) : base(message) { }
        public DirectorioLlenoException(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected DirectorioLlenoException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
