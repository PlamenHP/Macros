using System.Collections.Generic;
using System.Linq;
using Macros.Domain.Common;
using Macros.Domain.Food.Exceptions;
using static Macros.Domain.Food.Models.ModelConstants.Common;

namespace Macros.Domain.Food.Models.Menu
{
    public class FoodList : Entity<int>, IAggregateRoot
    {
        private readonly HashSet<Nutrient> foods;

        internal FoodList(string name, string creator = "Anonimous creator")
        {
            this.Validate(name);
            this.Name = name;

            this.Validate(creator);
            this.Creator = creator;

            this.foods = new HashSet<Nutrient>();
        }

        public string Name { get; private set; }

        public string Creator { get; private set; }

        public IReadOnlyCollection<Nutrient> Foods => this.foods.ToList().AsReadOnly();

        public void AddFood(Nutrient nutrient) => this.foods.Add(nutrient);

        private void Validate(string name)
            => Guard.ForStringLength<InvalidFoodListException>(
                name,
                MinNameLength,
                MaxNameLength,
                nameof(this.Name));
    }
}
