using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Services.Services;

namespace Services.Configuration
{
    public static class ServicesConfiguration
    {
        public static void SLServicesConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
        }
    }
}
