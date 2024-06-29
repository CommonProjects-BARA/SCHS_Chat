using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Common.API.Handlers
{
    public static class CommonHandlersRegistration
    {
        public static IServiceCollection AddCommonMiddlewares(this IServiceCollection services)
        {
            services.AddTransient<GlobalExceptionHandler>();

            return services;
        }

        public static IApplicationBuilder UseCommonMiddlewares(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalExceptionHandler>();

            return app;
        }
    }

}
