using System;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public class SeatableException : Exception
    {
        public SeatableException()
        {
        }

        public SeatableException(string messages) : base(messages)
        {
        }

        public SeatableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
