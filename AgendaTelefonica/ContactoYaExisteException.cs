using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    [Serializable]
    public class ContactoYaExisteException : Exception
    {
        public ContactoYaExisteException() : base() { }
        public ContactoYaExisteException(string message) : base(message) { }
        public ContactoYaExisteException(string message, Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected ContactoYaExisteException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
