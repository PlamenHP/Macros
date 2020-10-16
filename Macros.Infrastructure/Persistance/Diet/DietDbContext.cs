using System.Reflection;
using Macros.Domain.Food.Models.Diet;
using Microsoft.EntityFrameworkCore;

namespace Macros.Infrastructure.Persistance.Diet
{
    internal class DietDbContext : DbContext
    {
        public DietDbContext(DbContextOptions<DietDbContext> options)
            :base(options)
        {
        }

        public DbSet<ConsumedFoodList> consumedFoodLists { get; set; } = default!;

        public DbSet<Nutrient> Nutrients { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
