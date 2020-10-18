using System.Reflection;
using Macros.Domain.Food.Models.Diet;
using Microsoft.EntityFrameworkCore;

namespace Macros.Infrastructure.Persistence.Diet
{
    // Add-Migration InitialDomainTables -OutputDir "Persistence/Diet/Migrations" -context "DietDbContext"
    internal class DietDbContext : DbContext
    {
        public DietDbContext(DbContextOptions<DietDbContext> options)
            :base(options)
        {
        }

        public DbSet<ConsumedFoodList> ConsumedFoodLists { get; set; } = default!;

        public DbSet<Nutrient> Nutrients { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
