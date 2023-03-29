﻿using System;

namespace LineMessagingAPI.Core.Exceptions
{
    /// <summary>
    /// Capture Invalid Signature Exception.
    /// </summary>
    public class UserIdMismatchException : Exception
    {
        public UserIdMismatchException()
        {
        }

        public UserIdMismatchException(string message) : base(message)
        {
        }

        public UserIdMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
