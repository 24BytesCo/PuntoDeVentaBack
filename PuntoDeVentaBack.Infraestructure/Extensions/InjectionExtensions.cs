using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVentaBack.Infraestucture.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaBack.Infraestructure.Extensions
{
    public static class InjectionExtensions
    {
        // Extensión que agrega configuraciones de inyección de dependencias para la infraestructura.
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Obtiene el nombre completo del ensamblado que contiene la clase posContext.
            var assembly = typeof(posContext).Assembly.FullName;

            // Agrega el DbContext posContext a los servicios con configuraciones específicas.
            services.AddDbContext<posContext>(

                // Configura el DbContext para utilizar SQL Server con la cadena de conexión obtenida desde la configuración.
                options => options.UseSqlServer(
                    configuration.GetConnectionString("PosConnectionString"), b => b.MigrationsAssembly(assembly)
                ),

                // Establece el tiempo de vida del DbContext como Transient.
                ServiceLifetime.Transient
            );

            // Devuelve la colección de servicios para permitir la encadenación de métodos.
            return services;
        }
    }
}
