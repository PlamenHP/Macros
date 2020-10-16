using Macros.Infrastructure.Diet.Persistance;
using Macros.Infrastructure.Menu.Persistance;
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
                    configuration.GetConnectionString("DietDbConnection"),
                    b => b.MigrationsAssembly(
                        typeof(DietDbContext).Assembly.FullName)))
                .AddDbContext<MenuDbContext>(options => options
                    .UseSqlServer(
                    configuration.GetConnectionString("MenuDbConnection"),
                    b => b.MigrationsAssembly(
                        typeof(MenuDbContext).Assembly.FullName)));

    }
}
