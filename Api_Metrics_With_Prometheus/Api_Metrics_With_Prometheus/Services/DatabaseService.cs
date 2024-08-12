using Api_Metrics_With_Prometheus.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Api_Metrics_With_Prometheus.Services
{
    public class DatabaseService
    {
        public static void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}
