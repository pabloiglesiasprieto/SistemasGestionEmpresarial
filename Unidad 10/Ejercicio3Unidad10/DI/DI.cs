using Data.Repositories;
using Domain.Interfaces;
using Domain.UseCases;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace CompositionRoot
    {
    public static class DI
    {
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPersonaRepository, PersonaRepositoryAzure>();
            services.AddScoped<IUseCases, GetAllPersonaUseCase>();

            return services;
        }
    }
}
