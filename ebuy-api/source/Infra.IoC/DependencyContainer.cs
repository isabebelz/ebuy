using ebuy.Application.Configurations.DependencyInjection;
using ebuy.WebApi.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ebuy.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplication()
                    .AddServices()
                    .AddRepositories()
                    .ConfigureMapping();

            return services;
        }

        private static IServiceCollection AddApplication(this IServiceCollection services)
        {

            ApplicationServices.AddApplicationServices(services);

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}
