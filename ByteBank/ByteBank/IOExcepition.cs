using System;
using System.Runtime.Serialization;

namespace ByteBank
{
    [Serializable]
    internal class IOExcepition : Exception
    {
        public IOExcepition()
        {
        }

        public IOExcepition(string message) : base(message)
        {
        }

        public IOExcepition(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IOExcepition(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}