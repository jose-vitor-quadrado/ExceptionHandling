using System;

namespace Fintech.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
