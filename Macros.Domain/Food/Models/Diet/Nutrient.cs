using System;
using Macros.Domain.Common;
using Macros.Domain.Food.Exceptions;
using static Macros.Domain.Food.Models.ModelConstants.Common;
using static Macros.Domain.Food.Models.ModelConstants.Nutrient;

namespace Macros.Domain.Food.Models.Diet
{
    public class Nutrient : Entity<int>
    {
        internal Nutrient(string name, double quantity, DateTime consumptionTime)
        {
            this.ValidateName(name);
            this.ValidateQuantity(quantity);

            this.Name = name;
            this.Quantity = quantity;
            this.ConsumptionTime = consumptionTime;
        }

        private Nutrient(string name, double quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.ConsumptionTime = default!;
        }

        public string Name { get; }

        public double Quantity { get; private set; }

        public DateTime ConsumptionTime { get; }

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

        private void ValidateQuantity(double quantity)
            => Guard.AgainstOutOfRange<InvalidNutrientException>(
                quantity,
                MinQuantity,
                MaxQuantity,
                nameof(this.Quantity));
    }
}
