namespace Common.API.Handlers
{
    public static class CommonHandlersRegistration
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<GlobalExceptionHandler>();

            return services;
        }

        public static IApplicationBuilder UseHandlers(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalExceptionHandler>();

            return app;
        }
    }

}
