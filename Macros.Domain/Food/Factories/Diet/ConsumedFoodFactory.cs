using System;
using System.Collections.Generic;
using System.Text;
using Macros.Domian.Food.Models.Diet;

namespace Macros.Domian.Food.Factories.Diet
{
    internal class ConsumedFoodFactory : IConsumedFoodFactory
    { 
        private string user = default;

        private string name = default;

        public IConsumedFoodFactory WithName(string name)
        {
            throw new NotImplementedException();
        }

        public IConsumedFoodFactory WithUser(string user)
        {
            throw new NotImplementedException();
        }
        public ConsumedFood Build()
        {
            if (true)
            {

            }
        }
    }
}
