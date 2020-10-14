using Macros.Domian.Common;
using Macros.Domian.Food.Models.Diet;

namespace Macros.Domian.Food.Factories.Diet
{
    public interface IConsumedFoodListFactory : IFactory<ConsumedFoodList>
    {
        IConsumedFoodListFactory WithUser(string user);
        IConsumedFoodListFactory WithName(string name);
    }
}
