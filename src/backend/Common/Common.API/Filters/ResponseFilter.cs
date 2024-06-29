using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Common.API.Filters
{
    public class ResponseFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext _)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult 
                && context.HttpContext.Response.StatusCode == StatusCodes.Status200OK)
            {
                var value = objectResult.Value;
                objectResult.Value = ResponseApi<object>.Success(value);
            }
        }
    }
}