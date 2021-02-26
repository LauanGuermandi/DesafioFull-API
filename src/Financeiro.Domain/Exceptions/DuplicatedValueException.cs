using System;

namespace Financeiro.Domain.Exceptions
{
    public class DuplicatedValueException : Exception
    {
        public string Field { get; private set; }
        public DuplicatedValueException(string field, string message) : base(message)
        {
            Field = field;
        }
    }
}
