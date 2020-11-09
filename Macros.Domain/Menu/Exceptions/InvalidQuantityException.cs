using Macros.Domain.Common.Exceptions;

namespace Macros.Domain.Menu.Exceptions
{
    public class InvalidQuantityException : BaseDomainException
    {
        public InvalidQuantityException()
        {
        }

        public InvalidQuantityException(string error) => this.Error = error;
    }
}
