using Macros.Domain.Common;
using Macros.Domain.Food.Exceptions;
using static Macros.Domain.Food.Models.ModelConstants.Common;
using static Macros.Domain.Food.Models.ModelConstants.Nutrient;

namespace Macros.Domain.Food.Models.Menu
{
    public class Nutrient : Entity<int>
    {
        internal Nutrient(string name, double fat, double carbohydrate, double protein, double salt, QuantityType quantityType, double quantity)
        {
            ValidateName(name);
            ValidateNutrient(fat, this.Fat);
            ValidateNutrient(carbohydrate, this.Carbohydrate);
            ValidateNutrient(protein, this.Protein);
            ValidateNutrient(salt, this.Salt);
            ValidateQuantity(quantity);

            this.Name = name;
            this.Fat = fat;
            this.Carbohydrate = carbohydrate;
            this.Salt = salt;
            this.QuantityType = quantityType;
            this.Quantity = quantity;
        }

        public string Name { get; private set; }

        public double Fat { get; private set; }

        public double Carbohydrate { get; private set; }

        public double Protein { get; private set; }

        public double Salt { get; private set; }

        public QuantityType QuantityType { get; private set; }

        public double Quantity { get; private set; }

        public Nutrient UpdateName(string name)
        {
            ValidateName(name);
            this.Name = name;

            return this;
        }

        public Nutrient UpdateFat(double fat)
        {
            ValidateNutrient(fat, this.Fat);
            this.Fat = fat;

            return this;
        }

        public Nutrient UpdateCarbohydrate(double carbohydrate)
        {
            ValidateNutrient(carbohydrate, this.Carbohydrate);
            this.Carbohydrate = carbohydrate;

            return this;
        }

        public Nutrient UpdateProtein(double protein)
        {
            ValidateNutrient(protein, this.Protein);
            this.Protein = protein;

            return this;
        }

        public Nutrient UpdateSalt(double salt)
        {
            ValidateNutrient(salt, this.Salt);
            this.Salt = salt;

            return this;
        }

        public Nutrient UpdateQuantityType(QuantityType quantityType)
        {
            this.QuantityType = quantityType;

            return this;
        }

        public Nutrient UpdateQuantity(double quantity)
        {
            ValidateQuantity(quantity);
            this.Quantity = quantity;

            return this;
        }

        private void ValidateName(string name)
            => Guard.ForStringLength<InvalidNutrientException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));

        private void ValidateNutrient(double nutrient, double property)
            => Guard.AgainstOutOfRange<InvalidNutrientException>(
                Fat,
                MinMacronutrientCount,
                MaxMacronutrientCount,
                nameof(property)); 

        private void ValidateQuantity(double quantity)
            => Guard.AgainstOutOfRange<InvalidNutrientException>(
                quantity,
                MinQuantity,
                MaxQuantity,
                nameof(this.Quantity));


    }
}
