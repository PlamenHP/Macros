using Macros.Domain.Common.Factories;
using Macros.Domain.Menu.Models;

namespace Macros.Domain.Menu.Factories
{
    public interface IFoodFactory : IFactory<Food>
    {
        IFoodFactory FromUser(string userId);
        IFoodFactory WithCategory(Category category);
        IFoodFactory WithName(string name);
        IFoodFactory WithQuantityType(QuantityType quantityType);
        IFoodFactory WithQuantity(double quantity);
        IFoodFactory WithFat(double fat);
        IFoodFactory WithCarbohydrate(double carbohydrate);
        IFoodFactory WithProtein(double protein);
        IFoodFactory WithSalt(double salt);
    }
}
