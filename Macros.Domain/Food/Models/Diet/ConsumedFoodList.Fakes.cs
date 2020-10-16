using System;
using FakeItEasy;

namespace Macros.Domain.Food.Models.Diet
{
    public class ConsumedFoodListFakes
    {
        public class ConsumedFoodListDummyFactory : IDummyFactory
        {
            public Priority Priority => Priority.Default;

            public bool CanCreate(Type type) => true;

            public object? Create(Type type) => new ConsumedFoodList("fake user","fake name");
        }
    }
}
