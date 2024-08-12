using Api_Metrics_With_Prometheus.Dominio.Register;
using Microsoft.EntityFrameworkCore;

namespace Api_Metrics_With_Prometheus.Dominio
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<RegisterModel> Register { get; set; }
    }
    
}
