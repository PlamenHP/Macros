using System.Reflection;
using Macros.Domain.Food.Models.Menu;
using Microsoft.EntityFrameworkCore;

namespace Macros.Infrastructure.Persistance.Menu
{
    internal class MenuDbContext : DbContext
    {
        public MenuDbContext(DbContextOptions<MenuDbContext> options)
            : base(options)
        {

        }

        public DbSet<FoodList> FoodLists { get; set; } = default!;

        public DbSet<Nutrient> Nutrients { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
