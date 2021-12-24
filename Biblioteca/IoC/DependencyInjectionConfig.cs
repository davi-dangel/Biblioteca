using Biblioteca.Application.Applications;
using Biblioteca.Application.Validation;
using Biblioteca.Domain.Interfaces.Application;
using Biblioteca.Domain.Interfaces.Repositories;
using Biblioteca.Domain.ViewModels.Livro;
using Biblioteca.Repository.Repositories;
using FluentValidation;
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

        public static IServiceCollection ResolveValidationDependencies(this IServiceCollection services)
        {
            services.AddTransient<IValidator<LivroParaInserirVM>, LivroParaInserirVMValidator>();

            return services;
        }
    }
}
