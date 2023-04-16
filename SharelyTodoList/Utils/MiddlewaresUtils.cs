using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using SharelyTodoList.Exceptions;

namespace SharelyTodoList.Utils;

public static class MiddlewaresUtils
{
    public static Task HandleExceptionMessageAsync(HttpContext context, ApiException apiException)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)apiException.StatusCode;

        var responseBody = new ProblemDetails()
        {
            Status = (int)apiException.StatusCode,
            Title = ReasonPhrases.GetReasonPhrase((int)apiException.StatusCode),
            Detail = apiException.Message
        };

        string responseBodyString = JsonSerializer.Serialize(responseBody);

        return context.Response.WriteAsync(responseBodyString);
    }
}