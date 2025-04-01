using ebuy.Application.Configurations.DependencyInjection;
using ebuy.Domain.DomainServices;
using ebuy.Domain.Interfaces.Repositories;
using ebuy.Domain.SeedWork;
using ebuy.Infra.Data;
using ebuy.Infra.Data.Repositories;
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
            services.AddScoped(typeof(UserService));
            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IUnitOfWork), typeof(EbuyDbContext));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

            return services;
        }
    }
}
