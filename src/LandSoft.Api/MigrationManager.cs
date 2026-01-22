using LandSoft.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Writers;

namespace LandSoft.Api
{
    public static class MigrationManager
    {
        public static WebApplication MigrationDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<LandSoftContext>())
                {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }
    }
}