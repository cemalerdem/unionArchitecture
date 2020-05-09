using Microsoft.Extensions.DependencyInjection;
using UnionArcDemo.ApplicationCore.Interfaces.Services;
using UnionArcDemo.ApplicationCore.Services;

namespace UnionArcDemo.ApplicationCore.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection ApplicationCoreDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}