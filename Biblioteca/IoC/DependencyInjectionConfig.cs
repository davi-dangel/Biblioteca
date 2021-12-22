using Biblioteca.Application.Applications;
using Biblioteca.Domain.Interfaces.Application;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace Biblioteca.Api.IoC
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<ILivroRepository, LivroRepository>();

            return services;
        }

        public static IServiceCollection ResolveApplicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<ILivroApplication, LivroApplication>();

            return services;
        }
    }
}
