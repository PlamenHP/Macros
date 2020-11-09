using Macros.Infrastructure.Persistance.Diet;
using Macros.Infrastructure.Persistance.Menu;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Macros.Infrastructure
{
    public static class InfrastructureConfigurationk
    {
        public static IServiceCollection AddInfrastructure(
                this IServiceCollection services,
                IConfiguration configuration)
            => services
                .AddDbContext<DietDbContext>(options => options
                    .UseSqlServer(
                    configuration.GetConnectionString("DietDbConnectionString"),
                    b => b.MigrationsAssembly(
                        typeof(DietDbContext).Assembly.FullName)))
                .AddDbContext<MenuDbContext>(options => options
                    .UseSqlServer(
                    configuration.GetConnectionString("MenuDbConnectionString"),
                    b => b.MigrationsAssembly(
                        typeof(MenuDbContext).Assembly.FullName)));

    }
}
