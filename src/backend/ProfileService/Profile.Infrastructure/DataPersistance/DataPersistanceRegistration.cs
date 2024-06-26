using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Profile.Infrastructure.DataPersistance
{
    public static class DataPersistanceRegistration
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ProfileDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnectionString")));

            return services;
        }
    }
}
