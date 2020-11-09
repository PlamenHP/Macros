using Macros.Domain.Common.Models;

namespace Macros.Domain.Menu.Models
{
    public class Category : Enumeration
    {
        public static readonly Category Fruits = new Category(1, nameof(Fruits));
        public static readonly Category Vegetables = new Category(2, nameof(Vegetables));
        public static readonly Category Grains = new Category(3, nameof(Grains));
        public static readonly Category Meats = new Category(4, nameof(Meats));
        public static readonly Category Dairy = new Category(5, nameof(Dairy));
        public static readonly Category Drinks = new Category(5, nameof(Drinks));

        private Category(int value)
            : this(value, FromValue<Category>(value).Name)
        {
        }

        private Category(int value, string name)
            : base(value, name)
        {
        }
        
    }
}