using Microsoft.Extensions.DependencyInjection;
using Domain.Repositories;
using Domain.UseCases;
using Domain.Interfaces;
using Data.Repositories;

namespace CompositionRoot
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            // Repositorios
            services.AddScoped<IListadoMisiones, ListadoMisiones>();

            // Casos de uso
            services.AddScoped<IMediaNocheUseCase, MediaNocheUseCase>();

            return services;
        }
    }
}
