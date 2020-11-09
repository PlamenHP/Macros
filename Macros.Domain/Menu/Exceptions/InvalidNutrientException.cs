using Macros.Domain.Common.Exceptions;

namespace Macros.Domain.Menu.Exceptions
{
    public class InvalidNutrientException : BaseDomainException
    {
        public InvalidNutrientException()
        {
        }

        public InvalidNutrientException(string error) => this.Error = error;
    }
}
