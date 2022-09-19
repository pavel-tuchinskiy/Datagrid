using Domain.DTOs;
using Domain.Exceptions;
using Domain.Models;
using WebApi.Models;

namespace WebApi.Middlewares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception exception)
        {
            httpContext.Response.ContentType = "application/json";

            if(exception is ResponseException)
            {
                var ex = exception as ResponseException;

                httpContext.Response.StatusCode = ex.ErrorCode switch
                {
                    ErrorCodes.Err500 => StatusCodes.Status500InternalServerError,
                    ErrorCodes.Err400 => StatusCodes.Status400BadRequest,
                    _ => StatusCodes.Status404NotFound
                };

                var exDTO = new ResponseExceptionDTO(ex.Message, ex.Source, Enum.GetName(ex.ErrorCode));

                await httpContext.Response.WriteAsJsonAsync(new ReturnHttpResult(httpContext.Response.StatusCode, exception: exDTO));
            }
            else
            {
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var exDTO = new ResponseExceptionDTO(exception.Message, exception.Source, nameof(ErrorCodes.Err500));

                await httpContext.Response.WriteAsJsonAsync(new ReturnHttpResult(httpContext.Response.StatusCode, exception: exDTO));
            }
        }
    }
}
