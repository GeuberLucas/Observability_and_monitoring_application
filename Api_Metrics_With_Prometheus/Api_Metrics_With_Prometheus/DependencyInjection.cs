using Api_Metrics_With_Prometheus.Interface;
using Api_Metrics_With_Prometheus.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Api_Metrics_With_Prometheus
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {

            

            services.AddTransient<IRegisterRepository, RegisterRepository>();


            return services;
        }
    }
}
