using System;
namespace Financeiro.Domain.Exceptions
{
    public class InconsistentDataException : Exception
    {
        public InconsistentDataException(string message) : base(message)
        {
        }
    }
}
