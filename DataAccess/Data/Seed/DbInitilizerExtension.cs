using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Data.Seed
{
    public static class DbInitializerExtension
    {
        public async static Task<IApplicationBuilder> SeedDbData(this IApplicationBuilder app, IConfiguration configuration)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<GridDbContext>();
                await new DbInitializer().Initialize(context, configuration);
            }

            return app;
        }
    }
}
