using System.Reflection;
using MediatR;
using MediatR.Extensions.FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace Pilot.Application
{
    public static class DependencyInjection
    {
        // Método estático que extiende la interfaz IServiceCollection, usado para agregar configuraciones de servicios específicos de la capa de aplicación.
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Obtiene una referencia al ensamblado actual (donde reside esta clase).
            var applicationAssembly = Assembly.GetExecutingAssembly();

            // Agrega los servicios de MediatR al contenedor de servicios de ASP.NET Core.
            // MediatR es una biblioteca que implementa el patrón Mediator, facilitando la comunicación entre diferentes partes de la aplicación.
            services.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(applicationAssembly));
            // Agrega la integración de FluentValidation con MediatR al contenedor de servicios.
            // Esto permite validar comandos y consultas utilizando FluentValidation dentro del contexto de MediatR.
            services.AddFluentValidation(new[] { applicationAssembly });

            // Devuelve la colección de servicios después de realizar las configuraciones.
            return services;        
        }
    }
}