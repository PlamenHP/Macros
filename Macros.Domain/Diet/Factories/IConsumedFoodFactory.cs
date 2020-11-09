using Macros.Domain.Common.Factories;
using Macros.Domain.Diet.Models;

namespace Macros.Domain.Diet.Factories
{
    public interface IConsumedFoodListFactory : IFactory<ConsumedFoodList>
    {
        IConsumedFoodListFactory WithUser(string user);
        IConsumedFoodListFactory WithName(string name);
    }
}
