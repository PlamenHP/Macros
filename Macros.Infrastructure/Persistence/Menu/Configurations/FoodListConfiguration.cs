using Macros.Domain.Food.Models.Menu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Food.Models.ModelConstants.Common;

namespace Macros.Infrastructure.Persistence.Menu.Configurations
{
    internal class FoodListConfiguration
    {
        public void Configure(EntityTypeBuilder<FoodList> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(f => f.Creator)
                .HasMaxLength(MaxNameLength);

            builder
                .HasMany(f => f.Foods)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
