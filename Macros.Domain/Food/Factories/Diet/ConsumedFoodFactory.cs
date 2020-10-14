﻿using Macros.Domian.Food.Exceptions;
using Macros.Domian.Food.Models.Diet;

namespace Macros.Domian.Food.Factories.Diet
{
    internal class ConsumedFoodListFactory : IConsumedFoodListFactory
    { 
        private string user = default!;
        private string name = default!;

        private bool userSet = false;

        public IConsumedFoodListFactory WithUser(string user)
        {
            this.user = user;
            this.userSet = true;
            return this;
        }

        public IConsumedFoodListFactory WithName(string name)
        {
            this.name = name;
            return this;
        }

        public ConsumedFoodList Build()
        {
            if (!this.userSet)
            {
                throw new InvalidConsumedFoodListException("User must have a value.");
            }

            return new ConsumedFoodList(this.user, this.name);
        }
    }
}
