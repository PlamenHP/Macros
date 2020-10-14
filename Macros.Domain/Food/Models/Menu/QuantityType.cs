using Macros.Domain.Common;

namespace Macros.Domian.Food.Models.Menu
{
    public class QuantityType : Enumeration
    {
        public static readonly QuantityType Grams = new QuantityType(1, nameof(Grams));
        public static readonly QuantityType Mililiters = new QuantityType(2, nameof(Mililiters));
        public static readonly QuantityType Pieces = new QuantityType(3, nameof(Pieces));

        private QuantityType(int value)
            : this(value, FromValue<QuantityType>(value).Name)
        {
        }

        private QuantityType(int value, string name)
            : base(value, name)
        {
        }
    }
}
