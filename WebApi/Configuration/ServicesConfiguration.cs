using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Configuration
{
    public static class ServicesConfiguration
    {
        public static void ConfigureSqlConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GridDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConnection"));

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
