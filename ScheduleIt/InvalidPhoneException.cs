using System;
using System.Runtime.Serialization;

namespace ScheduleIt
{
    [Serializable]
    internal class InvalidPhoneException : Exception
    {
        public InvalidPhoneException()
        {
        }

        public InvalidPhoneException(string message) : base(message)
        {
        }

        public InvalidPhoneException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPhoneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}