using Macros.Domain.Exceptions;

namespace Macros.Domian.Food.Exceptions
{
    public class InvalidNutrientException : BaseDomainException
    {
        public InvalidNutrientException()
        {
        }

        public InvalidNutrientException(string error) => this.Error = error;
    }
}
