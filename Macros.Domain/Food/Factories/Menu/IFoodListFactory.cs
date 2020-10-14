using Macros.Domain.Food.Models.Menu;
using Macros.Domian.Common;
using Macros.Domian.Food.Models.Menu;

namespace Macros.Domian.Food.Factories.Menu
{
    public interface IFoodListFactory : IFactory<FoodList>
    {
        IFoodListFactory WithName(string name);

        IFoodListFactory WithCreator(string creator);
    }
}
