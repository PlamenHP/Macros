using Macros.Domain.Menu.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Common.ModelConstants.Common;

namespace Macros.Infrastructure.Persistance.Menu.Configurations
{
    internal class NutrientConfiguration
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder
                .HasKey(n => n.Id);

            builder
                .Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(n => n.Fat)
                .IsRequired();

            builder
                .Property(n => n.Carbohydrate)
                .IsRequired();

            builder
                .Property(n => n.Protein)
                .IsRequired();

            builder
                .Property(n => n.Salt)
                .IsRequired();

            builder
                .Property(n => n.QuantityType)
                .IsRequired();

            builder
                .Property(n => n.Quantity)
                .IsRequired();
        }
    }
}