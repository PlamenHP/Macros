using Macros.Domain.Common.Exceptions;

namespace Macros.Domain.Menu.Exceptions
{
    public class InvalidFoodException : BaseDomainException
    {
        public InvalidFoodException()
        {
        }

        public InvalidFoodException(string error) => this.Error = error;
    }
}