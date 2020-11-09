using Macros.Domain.Common.Exceptions;

namespace Macros.Domain.Diet.Exceptions
{
    public class InvalidConsumedFoodListException : BaseDomainException
    {
        public InvalidConsumedFoodListException()
        {
        }

        public InvalidConsumedFoodListException(string error) => this.Error = error;
    }
}
