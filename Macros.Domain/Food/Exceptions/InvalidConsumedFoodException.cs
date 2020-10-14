using Macros.Domain.Exceptions;

namespace Macros.Domian.Food.Exceptions
{
    public class InvalidConsumedFoodListException : BaseDomainException
    {
        public InvalidConsumedFoodListException()
        {
        }

        public InvalidConsumedFoodListException(string error) => this.Error = error;
    }
}
