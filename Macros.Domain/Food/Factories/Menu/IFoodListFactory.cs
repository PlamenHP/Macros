using Macros.Domain.Common;
using Macros.Domain.Food.Models.Menu;

namespace Macros.Domain.Food.Factories.Menu
{
    public interface IFoodListFactory : IFactory<FoodList>
    {
        IFoodListFactory WithName(string name);

        IFoodListFactory WithCreator(string creator);
    }
}
