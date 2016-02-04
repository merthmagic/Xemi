using System;
using System.Runtime.Serialization;

namespace Xemi.Core
{
    public class XException:Exception
    {
         public XException()
        { }

        public XException(string message)
            : base(message)
        {

        }

        public XException(string messageFormat, params object[] args)
            : base(string.Format(messageFormat, args))
        {

        }

        public XException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        public XException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}