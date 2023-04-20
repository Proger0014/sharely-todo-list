using SharelyTodoList.Exceptions;
using SharelyTodoList.Utils;

namespace SharelyTodoList.Extensions;

public static class MiddlewaresExtensions
{
    public static Task HandleExceptionMessageAsync(this ApiException apiException, HttpContext context)
    {
        return MiddlewaresUtils.HandleExceptionMessageAsync(context, apiException);
    }
}