using Macros.Domain.Exceptions;

namespace Macros.Domain.Food.Exceptions
{
    public class InvalidNutrientException : BaseDomainException
    {
        public InvalidNutrientException()
        {
        }

        public InvalidNutrientException(string error) => this.Error = error;
    }
}
