﻿using System;

namespace DevSquad.Exceptions
{
    public class UniqueIdentifierException : Exception
    {
        public UniqueIdentifierException()
        {

        }

        public UniqueIdentifierException(string message)
            : base(message)
        {

        }

        public UniqueIdentifierException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
