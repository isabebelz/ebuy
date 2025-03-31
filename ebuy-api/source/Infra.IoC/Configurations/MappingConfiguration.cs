using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ebuy.WebApi.Configurations
{
    public static class MappingConfiguration
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMappings();

            return services;
        }

        private static IServiceCollection AddMappings(this IServiceCollection services)
        {
            var configurationMapping = new MapperConfiguration(mc =>
            {

            });

            IMapper mapper = configurationMapping.CreateMapper();

            services.AddSingleton(mapper);

            return services;
        }
    }
}
