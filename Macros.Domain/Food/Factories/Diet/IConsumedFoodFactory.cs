using Macros.Domain.Common;
using Macros.Domain.Food.Models.Diet;

namespace Macros.Domain.Food.Factories.Diet
{
    public interface IConsumedFoodListFactory : IFactory<ConsumedFoodList>
    {
        IConsumedFoodListFactory WithUser(string user);
        IConsumedFoodListFactory WithName(string name);
    }
}
