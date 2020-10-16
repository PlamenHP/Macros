namespace Macros.Domain.Food.Models
{
    public class ModelConstants
    {
        public class Common
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 50;
            public const int MinEmailLength = 3;
            public const int MaxEmailLength = 50;
            public const int MaxUrlLength = 2048;
            public const int Zero = 0;
        }

        public class Nutrient
        {
            public const int MinMacronutrientCount = 0;
            public const int MaxMacronutrientCount = 200;
            public const int MinQuantity = 0;
            public const int MaxQuantity = 5000;
        }
    }
}
