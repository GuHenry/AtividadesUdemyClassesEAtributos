using System;

namespace TratamentoDeExcecoes.Expections
{
    public class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message)
        {
        }
    }
}
