using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pilot.Infrastructure.Persistence.DbContexts;


namespace Pilot.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Agrega el contexto de base de datos PilotDbContext al contenedor de servicios de ASP.NET Core.
            // Utiliza Entity Framework Core para trabajar con la base de datos SQL Server.
            // services.AddDbContext<PilotDbContext>(options =>
            //     options.UseAzureSql(
            //         configuration.GetConnectionString("DefaultConnection"),
            //         b => b.MigrationsAssembly(typeof(PilotDbContext).Assembly.FullName)));
            
            services.AddDbContext<PilotDbContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(PilotDbContext).Assembly.FullName)));

            // Devuelve la colección de servicios después de realizar las configuraciones.
            return services;        
        }
    }
}