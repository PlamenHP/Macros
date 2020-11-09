using Macros.Domain.Common;
using Macros.Domain.Common.Models;
using Macros.Domain.Menu.Exceptions;
using static Macros.Domain.Common.ModelConstants.Common;
using static Macros.Domain.Common.ModelConstants.Nutrient;

namespace Macros.Domain.Menu.Models
{
    public class Food : Entity<int>, IAggregateRoot 
    { 
        internal Food(string userId, Category category, string name, double quantity, QuantityType quantityType, double fat, double carbohydrate, double protein, double salt)
        {
            ValidateCategory(category);
            ValidateName(name);
            ValidateQuantity(quantity);
            ValidateNutrient(fat, this.Fat);
            ValidateNutrient(carbohydrate, this.Carbohydrate);
            ValidateNutrient(protein, this.Protein);
            ValidateNutrient(salt, this.Salt);

            this.UserId = userId;
            this.Category = category;
            this.Name = name;
            this.Fat = fat;
            this.Carbohydrate = carbohydrate;
            this.Salt = salt;
            this.QuantityType = quantityType;
            this.Quantity = quantity;

        }

        private Food(string userId, string name, double quantity, double fat, double carbohydrate, double protein, double salt)
        {
            this.UserId = userId;
            this.Name = name;
            this.Quantity = quantity;
            this.Fat = fat;
            this.Carbohydrate = carbohydrate;
            this.Protein = protein;
            this.Salt = salt;

            this.Category = default!;
            this.QuantityType = default!;
        }

        public string UserId { get; private set; }
        
        public Category Category { get; private set; }

        public string Name { get; private set; }

        public double Quantity { get; private set; }

        public QuantityType QuantityType { get; private set; }

        public double Fat { get; private set; }

        public double Carbohydrate { get; private set; }

        public double Protein { get; private set; }

        public double Salt { get; private set; }



        public Food UpdateCategory(Category category)
        {
            ValidateCategory(category);
            this.Category = category;

            return this;
        }

        public Food UpdateName(string name)
        {
            ValidateName(name);
            this.Name = name;

            return this;
        }


        public Food UpdateQuantity(double quantity)
        {
            ValidateQuantity(quantity);
            this.Quantity = quantity;

            return this;
        }

        public Food UpdateQuantityType(QuantityType quantityType)
        {
            this.QuantityType = quantityType;

            return this;
        }

        public Food UpdateFat(double fat)
        {
            ValidateNutrient(fat, this.Fat);
            this.Fat = fat;

            return this;
        }

        public Food UpdateCarbohydrate(double carbohydrate)
        {
            ValidateNutrient(carbohydrate, this.Carbohydrate);
            this.Carbohydrate = carbohydrate;

            return this;
        }

        public Food UpdateProtein(double protein)
        {
            ValidateNutrient(protein, this.Protein);
            this.Protein = protein;

            return this;
        }

        public Food UpdateSalt(double salt)
        {
            ValidateNutrient(salt, this.Salt);
            this.Salt = salt;

            return this;
        }

        private void ValidateCategory(Category category)
            => Guard.ForStringLength<InvalidCategoryException>(
                category?.Name ?? "",
                MinNameLength,
                MaxNameLength,
                nameof(this.Category));

        private void ValidateName(string name)
            => Guard.ForStringLength<InvalidFoodException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

        private void ValidateQuantity(double quantity)
            => Guard.AgainstOutOfRange<InvalidQuantityException>(
                quantity,
                MinQuantity,
                MaxQuantity,
                nameof(this.Quantity));

        private void ValidateQuantityType(QuantityType cuantityType)
            => Guard.ForStringLength<InvalidQuantityTypeException>(
                QuantityType?.Name ?? "",
                MinNameLength,
                MaxNameLength,
                nameof(this.QuantityType));

        private void ValidateNutrient(double nutrient, double property)
            => Guard.AgainstOutOfRange<InvalidNutrientException>(
                property,
                MinMacronutrientCount,
                MaxMacronutrientCount,
                nameof(property)); 


    }
}
