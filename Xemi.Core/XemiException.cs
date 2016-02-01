using System;
using System.Runtime.Serialization;

namespace Xemi.Core
{
    public class XemiException:Exception
    {
         public XemiException()
        { }

        public XemiException(string message)
            : base(message)
        {

        }

        public XemiException(string messageFormat, params object[] args)
            : base(string.Format(messageFormat, args))
        {

        }

        public XemiException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        public XemiException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}