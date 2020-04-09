using System;

namespace DevSquad.Exceptions
{
    public class TechLeaderNotFoundException : Exception
    {
        public TechLeaderNotFoundException()
        {

        }

        public TechLeaderNotFoundException(string message)
            : base(message)
        {

        }

        public TechLeaderNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
