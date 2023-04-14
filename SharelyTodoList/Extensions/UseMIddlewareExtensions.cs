using SharelyTodoList.Middlewares;

namespace SharelyTodoList.Extensions;

public static class UseMIddlewareExtensions
{
    public static void UseGlobalHandlingExceptions(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionHandlerMiddleware>();
    }
}