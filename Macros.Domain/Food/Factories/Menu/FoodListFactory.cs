using Macros.Domain.Food.Exceptions;
using Macros.Domain.Food.Models.Menu;

namespace Macros.Domain.Food.Factories.Menu
{
    public class FoodListFactory : IFoodListFactory
    {
        private string name = default!;
        private string creator = default!;

        private bool nameSet = false;

        public IFoodListFactory WithName(string name)
        {
            this.name = name;
            this.nameSet = true;
            return this;
        }

        public IFoodListFactory WithCreator(string creator)
        {
            this.creator = creator;
            return this;
        }

        public FoodList Build()
        {
            if (!nameSet)
            {
                throw new InvalidFoodListException("Name must have a value.");
            }

            return new FoodList(this.name, this.creator);
        }
    }
}
