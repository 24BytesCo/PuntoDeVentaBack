using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVentaBack.Infraestructure.Persistences.Interfaces;
using PuntoDeVentaBack.Infraestructure.Persistences.Repositories;
using PuntoDeVentaBack.Infraestucture.Context;

namespace PuntoDeVentaBack.Infraestructure.Extensions
{
    public static class InjectionExtensions
    {
        // Extensión que agrega configuraciones de inyección de dependencias para la infraestructura.
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Obtiene el nombre completo del ensamblado que contiene la clase PosContext.
            var assembly = typeof(PosContext).Assembly.FullName;

            // Agrega el DbContext PosContext a los servicios con configuraciones específicas.
            services.AddDbContext<PosContext>(

                // Configura el DbContext para utilizar SQL Server con la cadena de conexión obtenida desde la configuración.
                options => options.UseSqlServer(
                    configuration.GetConnectionString("PosConnectionString"), b => b.MigrationsAssembly(assembly)
                ),

                // Establece el tiempo de vida del DbContext como Transient.
                ServiceLifetime.Transient
            );

            //Configuracion del patron UnitOfWork
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            // Devuelve la colección de servicios para permitir la encadenación de métodos.
            return services;
        }
    }
}
