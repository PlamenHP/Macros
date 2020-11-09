using Macros.Domain.Menu.Exceptions;
using Macros.Domain.Menu.Models;

namespace Macros.Domain.Menu.Factories
{
    public class FoodFactory : IFoodFactory
    {
        private string foodUserId = default!;
        private Category foodCategory = default!;
        private string foodName = default!;
        private double foodQuantity = default!;
        private QuantityType foodQuantityType = default!;
        private double foodFat = default!;
        private double foodCarbohydrate = default!;
        private double foodProtein = default!;
        private double foodSalt = default!;

        private bool userIdSet = false;
        private bool nameSet = false;
        private bool categorySet = false;
        private bool quantityTypeSet = false;
        private bool quantitySet = false;
        private bool fatSet = false;
        private bool carbohydrateSet = false;
        private bool proteinSet = false;
        private bool saltSet = false;

        public IFoodFactory FromUser(string userId)
        {
            this.foodUserId = userId;
            this.userIdSet = true;
            return this;
        }  

        public IFoodFactory WithCategory(Category category)
        {
            this.foodCategory = category;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithName(string name)
        {
            this.foodName = name;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithQuantity(double quantity)
        {
            this.foodQuantity = quantity;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithQuantityType(QuantityType quantityType)
        {
            this.foodQuantityType = quantityType;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithFat(double fat)
        {
            this.foodFat = fat;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithCarbohydrate(double carbohydrate)
        {
            this.foodCarbohydrate = carbohydrate;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithProtein(double protein)
        {
            this.foodProtein = protein;
            this.nameSet = true;
            return this;
        }

        public IFoodFactory WithSalt(double salt)
        {
            this.foodSalt = salt;
            this.nameSet = true;
            return this;
        }

        public Food Build()
        {
            if (!categorySet)
            {
                throw new InvalidFoodException("Category must have a value.");
            }

            if (!nameSet)
            {
                throw new InvalidFoodException("Name must have a value.");
            }

            if (!quantitySet)
            {
                throw new InvalidFoodException("Quantity must have a value.");
            }
            
            if (!quantityTypeSet)
            {
                throw new InvalidFoodException("QuantityType must have a value.");
            }

            if (!fatSet)
            {
                throw new InvalidFoodException("Fat must have a value.");
            }

            if (!carbohydrateSet)
            {
                throw new InvalidFoodException("Carbohydrate must have a value.");
            }

            if (!proteinSet)
            {
                throw new InvalidFoodException("Protein must have a value.");
            }

            if (!saltSet)
            {
                throw new InvalidFoodException("Salt must have a value.");
            }

            return new Food(
                this.foodUserId,
                this.foodCategory,
                this.foodName,
                this.foodQuantity,
                this.foodQuantityType,
                this.foodFat,
                this.foodCarbohydrate,
                this.foodProtein,
                this.foodSalt);
        }
    }
}
