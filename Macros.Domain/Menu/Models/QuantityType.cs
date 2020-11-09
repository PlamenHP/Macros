using Macros.Domain.Common.Models;

namespace Macros.Domain.Menu.Models
{
    public class QuantityType : Enumeration
    {
        public static readonly QuantityType Grams = new QuantityType(1, nameof(Grams));
        public static readonly QuantityType Milliliters = new QuantityType(2, nameof(Milliliters));
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
