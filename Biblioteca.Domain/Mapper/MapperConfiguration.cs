using AutoMapper;
using Biblioteca.Domain.Mapper.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace Biblioteca.Domain.Mapper
{
    public static class MapperConfiguration
    {
        public static IServiceCollection MapperConfig(this IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(x =>
            {
                x.AddProfile<LivroProfile>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }

    }
}
