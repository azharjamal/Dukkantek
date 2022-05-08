
using Dukkantek.Domain.Interfaces;
using Dukkantek.Domain.Services;
using Dukkantek.Infrastructure.Context;
using Dukkantek.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Dukkantek.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DukkantekDbContext>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
