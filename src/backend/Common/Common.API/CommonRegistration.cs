using Common.API.Filters;
using Common.API.Handlers;

namespace Common.API
{
    public static class CommonRegistration
    {
        public static IServiceCollection AddCommon(this IServiceCollection services)
        {
            services.AddHandlers();
            services.AddControllers(cfg =>
            {
                cfg.Filters.Add<ResponseFilter>();
            });

            return services;
        }

        public static IApplicationBuilder UseCommon(this IApplicationBuilder app)
        {
            app.UseHandlers();

            return app;
        }
    }
}