using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.UI.Exceptions
{

    [Serializable]
    public class CanudinhoException : Exception
    {
        public CanudinhoException() { }
        public CanudinhoException(string message) : base(message) { }
        public CanudinhoException(string message, Exception inner) : base(message, inner) { }
        protected CanudinhoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }   
}
