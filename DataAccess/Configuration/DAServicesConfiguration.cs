using AutoMapper;
using DataAccess.Repositories;
using DataAccess.Validators;
using Domain.Interfaces.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Configuration
{
    public static class DAServicesConfiguration
    {
        public static void ConfigureDAServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IUserRepository, UsersRepository>();
            services.AddScoped<IProductRepository, ProductsRepository>();
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<OrderInfoPostValidator>();
            services.AddAutoMapper(typeof(MapperConfiguration));
        }
    }
}
