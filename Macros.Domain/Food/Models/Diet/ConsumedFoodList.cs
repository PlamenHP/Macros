using System.Collections.Generic;
using System.Linq;
using Macros.Domain.Common;
using Macros.Domain.Food.Exceptions;
using static Macros.Domain.Food.Models.ModelConstants.Common;

namespace Macros.Domain.Food.Models.Diet
{
    public class ConsumedFoodList : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Nutrient> foods;

        internal ConsumedFoodList( string user, string name = "The get to {0}% bodyfat diet list")
        {
            this.Validate(user);
            this.User = user;

            this.Validate(name);
            this.Name = string.Format(name, user.Length);

            this.foods = new HashSet<Nutrient>();
        }

        public string User { get; private set; }

        public string Name { get; private set; }

        public void UpdateName(string updatedName)
        {
            this.Name = updatedName;
        }

        public IReadOnlyCollection<Nutrient> Foods => this.foods.ToList().AsReadOnly();

        public void AddFood(Nutrient nutrient) => this.foods.Add(nutrient);

        private void Validate(string name)
            => Guard.ForStringLength<InvalidConsumedFoodListException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
    }
}
