using System;
using System.Runtime.Serialization;

namespace ScheduleIt
{
    [Serializable]
    internal class ScheduleException : Exception
    {
        public ScheduleException() : base("An unknown scheduling exception has occurred.")
        {
        }

        public ScheduleException(string message) : base(message)
        {
        }

        public ScheduleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ScheduleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}