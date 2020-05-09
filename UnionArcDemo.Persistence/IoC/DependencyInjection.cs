using Microsoft.Extensions.DependencyInjection;
using UnionArcDemo.ApplicationCore.Interfaces.EFInitialize;
using UnionArcDemo.ApplicationCore.Interfaces.Repositories;
using UnionArcDemo.Infrastructure.Repositories;
using UnionArcDemo.Infrastructure.Repositories.Base;

namespace UnionArcDemo.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection InfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}