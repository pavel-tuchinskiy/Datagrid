using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Data.Seed
{
    public static class DbInitializerExtension
    {
        public static IApplicationBuilder SeedDbData(this IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<GridDbContext>();
                new DbInitializer().Initialize(context);
            }

            return app;
        }
    }
}
