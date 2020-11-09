using Macros.Domain.Common.Exceptions;

namespace Macros.Domain.Menu.Exceptions
{
    public class InvalidQuantityTypeException : BaseDomainException
    {
        public InvalidQuantityTypeException()
        {
        }

        public InvalidQuantityTypeException(string error) => this.Error = error;
    }
}
