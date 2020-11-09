using Macros.Domain.Menu.Models;
using Macros.Infrastructure.Persistance.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Macros.Domain.Common.ModelConstants.Common;

namespace Macros.Infrastructure.Persistance.Menu.Configurations
{
    internal class FoodConfiguration
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder
                .HasKey(f => f.Id);

            builder
                .HasOne<User>()
                .WithOne()
                .HasForeignKey<Food>(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(MaxNameLength);

            builder
                .Property(f => f.UserId)
                .HasMaxLength(MaxNameLength);
        }
    }
}
