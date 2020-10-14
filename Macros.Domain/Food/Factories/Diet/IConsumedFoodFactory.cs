using Macros.Domian.Common;
using Macros.Domian.Food.Models.Diet;

namespace Macros.Domian.Food.Factories.Diet
{
    public interface IConsumedFoodFactory : IFactory<ConsumedFood>
    {
        IConsumedFoodFactory WithUser(string user);
        IConsumedFoodFactory WithName(string name);
    }
}
