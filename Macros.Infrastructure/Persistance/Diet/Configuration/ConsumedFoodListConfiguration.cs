using Macros.Domain.Diet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Common.ModelConstants.Common;

namespace Macros.Infrastructure.Persistance.Diet.Configuration
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
