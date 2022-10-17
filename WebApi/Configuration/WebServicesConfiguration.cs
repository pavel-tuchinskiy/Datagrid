using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace WebApi.Configuration
{
    public static class WebServicesConfiguration
    {
        public static void ConfigureSqlConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GridDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"));

            });
        }

        public static void ConfigureMongoClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IMongoClient, MongoClient>(options =>
            {
                var connection = configuration.GetConnectionString("MongoDb");
                return new MongoClient(connection);
            });
        }

        public static void ConfigureCORS(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("GridCors", pol =>
                {
                    pol.AllowAnyOrigin();
                    pol.AllowAnyHeader();
                    pol.AllowAnyMethod();
                });
            });
        }
    }
}
