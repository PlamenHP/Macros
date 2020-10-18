using Macros.Domain.Food.Models.Diet;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Food.Models.ModelConstants.Common;

namespace Macros.Infrastructure.Persistence.Diet.Configurations
{
    internal class NutrientConfiguration
    {
        public void Configure(EntityTypeBuilder<Nutrient> builder)
        {
            builder
                .HasKey(n => n.Id);

            builder
                .Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(n => n.Quantity)
                .IsRequired();

            builder
                .Property(n => n.ConsumptionTime)
                .IsRequired();
        }
    }
}