using Macros.Domain.Food.Models.Diet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Food.Models.ModelConstants.Common;

namespace Macros.Infrastructure.Persistence.Diet.Configuration
{
    internal class ConsumedFoodListConfiguration
    {
        public void Configure(EntityTypeBuilder<ConsumedFoodList> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .Property(f => f.User)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(f => f.Name)
                .HasMaxLength(MaxNameLength);

            builder
                .HasMany(f => f.Foods)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
