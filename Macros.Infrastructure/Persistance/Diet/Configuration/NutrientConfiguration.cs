using Macros.Domain.Diet.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Common.ModelConstants.Common;

namespace Macros.Infrastructure.Persistance.Diet.Configuration
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