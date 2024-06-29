using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Common.API.Handlers
{
    public class GlobalExceptionHandler : IMiddleware
    {
        private readonly ILogger _logger;
        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                await Handle(context, ex);
            }
        }
        public static async Task Handle(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";

            var responseModel = ResponseApi<string>.Fail(exception.Message);

            response.StatusCode = exception switch
            {
                ApplicationException e => (int) HttpStatusCode.InternalServerError,
                ValidationException e => (int) HttpStatusCode.BadRequest,
                _ => (int)HttpStatusCode.InternalServerError
            };

            var jsonResponse = JsonSerializer.Serialize(responseModel);

            await response.WriteAsync(jsonResponse);
        }
    }
}
