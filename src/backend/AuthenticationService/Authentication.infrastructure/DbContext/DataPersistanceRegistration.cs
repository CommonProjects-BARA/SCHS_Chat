using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication.infrastructure.DbContext
{
    public static class DataPersistanceRegistration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AuthDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("DbConnectionString")));
            
            return services;
        }
    }
}