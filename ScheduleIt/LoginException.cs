using System;
using System.Runtime.Serialization;

namespace ScheduleIt
{
    [Serializable]
    internal class LoginException : Exception
    {
        public LoginException()
        {
        }

        public LoginException(string message) : base(Properties.Resources.LoginError)
        {
        }

        public LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LoginException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}