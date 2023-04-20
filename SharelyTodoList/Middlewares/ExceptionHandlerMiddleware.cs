using SharelyTodoList.Exceptions;
using SharelyTodoList.Extensions;

namespace SharelyTodoList.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next.Invoke(context);
        }
        catch (ApiException ex)
        {
            await ex.HandleExceptionMessageAsync(context);
        }
    }
}