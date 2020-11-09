using System.Reflection;
using Macros.Domain.Menu.Models;
using Microsoft.EntityFrameworkCore;

namespace Macros.Infrastructure.Persistance.Menu
{
    internal class MenuDbContext : DbContext
    {
        public MenuDbContext(DbContextOptions<MenuDbContext> options)
            : base(options)
        {

        }

        public DbSet<Food> FoodLists { get; set; } = default!;

        public DbSet<Food> Nutrients { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
